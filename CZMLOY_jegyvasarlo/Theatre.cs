using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace CZMLOY_jegyvasarlo
{
    class Theatre
    {
        DataBase db;
        private List<Seat> seats=new List<Seat>();

        public List<Seat> getList() { return seats; }

        public Theatre(DataBase db)
        {
            this.db = db;
        }

        public void addSeat(Seat s)
        {
            seats.Add(s);
        }

        public List<Seat> getOccupied(int playID)
        {
            List<Seat> occupied = new List<Seat>();
            DataTable dt = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM VETELEK WHERE eloadas_id="+playID+"",db.GetConnecton());
            SQLiteDataAdapter sda=new SQLiteDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow r in dt.Rows)
                {
                    int id = int.Parse(r[0].ToString());
                    int pos = int.Parse(r[1].ToString());
                    int row = int.Parse(r[2].ToString());
                    int col = int.Parse(r[3].ToString());
                    Seat s = new Seat(id, pos, row, col);
                    occupied.Add(s);
                }
            return occupied;
        }

        public void setAvailabiity(List<Seat> o)
        {
            foreach(Seat s in seats)
            {
                if (o.Contains(s)) s.Free=false;
            }
        }
    }
}
