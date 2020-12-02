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
using System.ComponentModel;

namespace CZMLOY_jegyvasarlo
{
    class Customer
    {
        DataGridView gd;
        int cupon_id = 0;
        int discount = 0;
        int price = 0;
        List<Seat> reserved = new List<Seat>();
        struct Element
        {

            public int id { get; set; }
            public String pos { get; set; }
            public String place { get; set; }
            public String category { get; set; }
            public int price { get; set; }

            public Element(int id, int pos, string place, string category)
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
                    case "KARZAT":
                        return 6000;
                    case "VIP":
                        return 12000;
                    default:
                        return 0;
                }
            }

            private static String whatPos(int pos)
            {
                switch (pos)
                {
                    case 0:
                        return "Zsöllye";
                    case 1:
                        return "Karzat";
                    default:
                        return "Bent";
                }
            }
        }
        BindingList<Element> elements = new BindingList<Element>();

        public void calcPrice(Label label)
        {
            price = 0;
            foreach(Element e in elements)
            {
               price += e.price - e.price * discount / 100;
            }
            label.Text = price.ToString()+" HUF";
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
                DataBase db = new DataBase();
                SQLiteCommand cmd = new SQLiteCommand("Select id, ertek from KEDVEZMENYEK where kupon='" + inp + "'", db.GetConnecton());
                SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cupon_id = int.Parse(dt.Rows[0][0].ToString());
                discount = int.Parse(dt.Rows[0][1].ToString());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }

        public void updateDataView()
        {
            elements.Clear();
            foreach (Seat s in reserved)
            {
                Element e = new Element(s.Id, s.Pos, s.getPlace(), s.Cat);
                elements.Add(e);
            }

            gd.DataSource = elements;

        }

        public void payment(String name,int playId,DataBase db)
        {
            if (!name.Equals(""))
            {
                db.openConn();
                SQLiteTransaction trans = db.GetConnecton().BeginTransaction();
                try
                {
                    foreach(Element e in elements)
                    {
                       
                        SQLiteCommand cmd= new SQLiteCommand("INSERT INTO VETELEK (eloadas_id,hely_id,vevo,kupon_id)" +
                            "VALUES ("+playId+","+e.id+",'"+name+"',"+cupon_id+")",db.GetConnecton());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sikeres tranzakció! Fizetett összeg: {0}", price.ToString());
                    }
                    trans.Commit();
                }catch(Exception ex)
                {
                    trans.Rollback();
                    Debug.WriteLine(ex.StackTrace);
                    MessageBox.Show("Sikertelen tranzakció!");
                }
                finally
                {
                    db.closeConn();
                }
                
            }
            else
            {
                MessageBox.Show("Adja meg a nevét");
            }
        }
    }
}