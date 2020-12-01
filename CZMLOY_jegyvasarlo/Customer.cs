using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Text;

namespace CZMLOY_jegyvasarlo
{
    class Customer
    {
        DataGridView gd;
        String name;
        String coupon_id;
        int discount = 0;
        List<Seat> reserved = new List<Seat>();
        int priceToPay;

        struct element
        {

            public int id { get; set; }
            public String pos { get; set; }
            public String place { get; set; }
            public String category { get; set; }
            public int price { get; set; }

            public element(int id, int pos, string place, string category)
            {
                this.id = id;
                this.pos = whatPos(pos);
                this.place = place;
                this.category = category;
                this.price = calcPrice(category);
            }

            private static int calcPrice(String cat)
            {
                switch (cat)
                {
                    case "FOLDSZINT":
                        return 4000;
                        break;
                    case "KARZAT":
                        return 6000;
                        break;
                    case "VIP":
                        return 12000;
                        break;
                    default:
                        return 0;
                        break;
                }
            }

            private static String whatPos(int pos)
            {
                switch (pos)
                {
                    case 0:
                        return "Zsöllye";
                        break;
                    case 1:
                        return "Karzat";
                        break;
                    default:
                        return "Bent";
                        break;
                }
            }
        }

        public Customer(DataGridView gd)
        {
            this.gd = gd;
        }

        internal List<Seat> Reserved { get => reserved; set => reserved = value; }

        public void addSeat(Seat s)
        {
            Reserved.Add(s);
            updateDataView();
        }

        public void removeSeat(Seat s)
        {
            Reserved.Remove(s);
            updateDataView();
        }
        
        public void getDiscount(String inp)
        {
            try
            {
                DataBase db=new DataBase();
                SQLiteCommand cmd=new SQLiteCommand("Select id, ertek from KEDVEZMENYEK where kupon='"+inp+"'",db.GetConnecton());
                SQLiteDataAdapter sda=new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                coupon_id=dt.Rows[0][0].ToString();
                discount =int.Parse(dt.Rows[0][1].ToString());
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }

        public void updateDataView()
        {
            List<element> elements = new List<element>();
            foreach(Seat s in reserved)
            {
                element e = new element(s.Id,s.Pos,s.getPlace(),s.Cat);
                elements.Add(e);
            }

            gd.DataSource = elements;
            
        }

    }
}
