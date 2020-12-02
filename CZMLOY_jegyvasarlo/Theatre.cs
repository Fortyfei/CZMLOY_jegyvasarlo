using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace CZMLOY_jegyvasarlo
{
    class Theatre
    {
        DataBase db;
        SQLiteCommand cmd;
        SQLiteDataAdapter sda;
        Seat[,] lower = new Seat[6, 10];
        Seat[,] upper = new Seat[4, 8];

        public Theatre(DataBase db)
        {
            this.db = db;
            addLowerSeats();
            addUpperSeats();

        }

        private void addLowerSeats()
        {
            try
            {

                DataTable seats = new DataTable();
                cmd = new SQLiteCommand(
                    "SELECT * FROM HELYEK WHERE hely=0"
                    , db.GetConnecton()
                    );
                sda = new SQLiteDataAdapter(cmd);
                sda.Fill(seats);
                int i = 0, j = 0;
                foreach (DataRow r in seats.Rows)
                {
                    int id = int.Parse(r[0].ToString());
                    int pos = int.Parse(r[1].ToString());
                    int row = int.Parse(r[2].ToString());
                    int col = int.Parse(r[3].ToString());
                    String cat = r[4].ToString();
                    Seat s = new Seat(id, pos, row, col, cat);
                    lower[i, j] = s;
                    j++;
                    if (j > 9)
                    {
                        j = 0;
                        ++i;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private void addUpperSeats()
        {
            try
            {

                DataTable seats = new DataTable();
                cmd = new SQLiteCommand(
                    "SELECT * FROM HELYEK WHERE hely=1"
                    , db.GetConnecton()
                    );
                sda = new SQLiteDataAdapter(cmd);
                sda.Fill(seats);
                int i = 0, j = 0;
                foreach (DataRow r in seats.Rows)
                {
                    int id = int.Parse(r[0].ToString());
                    int pos = int.Parse(r[1].ToString());
                    int row = int.Parse(r[2].ToString());
                    int col = int.Parse(r[3].ToString());
                    String cat = r[4].ToString();
                    Seat s = new Seat(id, pos, row, col, cat);
                    upper[i, j] = s;
                    j++;
                    if (j > 7)
                    {
                        j = 0;
                        ++i;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }

        public List<int> findOccupied(int eloadasId)
        {
            resetSeats();
            List<int> seatIds = new List<int>();
            try
            {
                DataTable seats = new DataTable();
                cmd = new SQLiteCommand(
                    "SELECT * FROM VETELEK WHERE eloadas_id="+eloadasId.ToString()
                    , db.GetConnecton()
                    );
                sda = new SQLiteDataAdapter(cmd);
                sda.Fill(seats);
                foreach(DataRow r in seats.Rows)
                {
                    int id = int.Parse(r[1].ToString());
                    seatIds.Add(id);
                }
                
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }

            for (int i = 0; i < 6; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    if (seatIds.Contains(lower[i, j].Id))
                    {
                        lower[i, j].Free = false; //C
                    }
                }
            }

            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    if (seatIds.Contains(upper[i, j].Id))
                    {
                        upper[i, j].Free = false; //C
                    }
                }
            }


            return seatIds;
        }

        public void coronaRes(List<int> seatIds)
        {
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    if (seatIds.Contains(upper[i, j].Id))
                    {
                        if (i - 1 >= 0 && j - 1 >= 0) upper[i - 1, j - 1].Free = false; //NW
                        if (i - 1 >= 0) upper[i - 1, j].Free = false; //N
                        if (i - 1 >= 0 && j + 1 < 8) upper[i - 1, j + 1].Free = false; //NE
                        if (j - 2 >= 0) upper[i, j - 2].Free = false; //WW
                        if (j - 1 >= 0) upper[i, j - 1].Free = false; //W
                        //upper[i, j].Free = false; //C
                        if (j + 1 < 8) upper[i, j + 1].Free = false; //E
                        if (j + 2 < 8) upper[i, j + 2].Free = false; //EE
                        if (i + 1 < 4 && j - 1 >= 0) upper[i + 1, j - 1].Free = false;  //SW
                        if (i + 1 < 4) upper[i + 1, j].Free = false; //S
                        if (i + 1 < 4 && j + 1 < 8) upper[i + 1, j + 1].Free = false; //SE
                    }
                }
            }

            for (int i = 0; i < 6; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    if (seatIds.Contains(lower[i, j].Id))
                    {
                        if (i - 1 >= 0 && j - 1 >= 0) lower[i - 1, j - 1].Free = false; //NW
                        if (i - 1 >= 0) lower[i - 1, j].Free = false; //N
                        if (i - 1 >= 0 && j + 1 < 10) lower[i - 1, j + 1].Free = false; //NE
                        if (j - 2 >= 0) lower[i, j - 2].Free = false; //WW
                        if (j - 1 >= 0) lower[i, j - 1].Free = false; //W
                        //lower[i, j].Free = false; //C
                        if (j + 1 < 10) lower[i, j + 1].Free = false; //E
                        if (j + 2 < 10) lower[i, j + 2].Free = false; //EE
                        if (i + 1 < 6 && j - 1 >= 0) lower[i + 1, j - 1].Free = false;  //SW
                        if (i + 1 < 6) lower[i + 1, j].Free = false; //S
                        if (i + 1 < 6 && j + 1 < 10) lower[i + 1, j + 1].Free = false; //SE
                    }
                }
            }
        }

        private void resetSeats()
        {
            foreach(Seat s in getLowerSeats()) s.reset();
            foreach(Seat s in getUpperSeats()) s.reset();
        }

        public List<Seat> getLowerSeats()
        {
            List<Seat> ret = new List<Seat>();
            for (int i = 0; i < 6; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    ret.Add(lower[i, j]);
                }
            }
            return ret;
        }

        public List<Seat> getUpperSeats()
        {
            List<Seat> ret = new List<Seat>();
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    ret.Add(upper[i, j]);
                }
            }
            return ret;
        }

        public Seat getSeatById(int id)
        {
            if (id > 60)
            {
                //karzat
                for(int i = 0; i < 4; ++i)
                {
                    for(int j = 0; j < 8; ++j)
                    {
                        if (upper[i, j].Id == id) return upper[i, j];
                    }
                }
            }
            else
            {
                //zsöllye
                for (int i = 0; i < 6; ++i)
                {
                    for (int j = 0; j < 10; ++j)
                    {
                        if (lower[i, j].Id == id) return lower[i, j];
                    }
                }
            }
            return null;
        }
    }
}
