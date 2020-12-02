using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;
using System.ComponentModel;

namespace CZMLOY_jegyvasarlo
{
    public partial class AdminForm : Form
    {

        DataTable dt;
        SQLiteDataAdapter sda;
        SQLiteCommand cmd;
        DataBase db = new DataBase();
        Theatre th;
        Dictionary<int, int> discounts = new Dictionary<int, int>();
        private int selectedPlayId;
        private List<Play> listofPlays = new List<Play>();
        struct BuyerElement
        {
            public String Name { get; set; }
            public String Place { get; set; }
            public int Cupon { get; set; }
            public String Category { get; set; }
            public int Payed { get; set; }

            public BuyerElement(string name, String place, int cupon, string category, int payed)
            {
                Name = name;
                Place = place;
                Cupon = cupon;
                Category = category;
                Payed = payed;
            }
        }
        private BindingList<BuyerElement>customers=new BindingList<BuyerElement>();

        public AdminForm()
        {
            InitializeComponent();
            th = new Theatre(db);
            try
            {
                dt = new DataTable();
                cmd = new SQLiteCommand("Select * from ELOADASOK", db.GetConnecton());
                sda = new SQLiteDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    int id = int.Parse(row[0].ToString());
                    String date = row[1].ToString();
                    String name = row[2].ToString();
                    Play p = new Play(id, date, name);
                    listofPlays.Add(p);
                    cmb_eloadasok.Items.Add(p.printOut());
                }

                dt = new DataTable();
                cmd = new SQLiteCommand(
                    "SELECT id, ertek FROM KEDVEZMENYEK ", db.GetConnecton()
                    );
                sda = new SQLiteDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow r in dt.Rows)
                {
                    int id = int.Parse(r[0].ToString());
                    int dsc = int.Parse(r[1].ToString());
                    discounts.Add(id, dsc);
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Készítette: Koloh János Krisztián (CZMLOY)\n");
        }

        private int getPlayId(string inp)
        {
            String date = inp.Split('-')[0];
            String name = inp.Split('-')[1];
            for (int i = 0; i < listofPlays.Count(); ++i)
            {
                if (date.Equals(listofPlays[i].Date) && name.Equals(listofPlays[i].Name))
                {
                    return i + 1;
                }
            }
            return 0;
        }

        private void cmb_eloadasok_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPlayId = getPlayId(cmb_eloadasok.Text);
            th.findOccupied(selectedPlayId);
            pn_floor.Controls.Clear();
            pn_upper.Controls.Clear();
            int i = 1;
            foreach (Seat s in th.getLowerSeats())
            {
                Button btn = s.setupButton();
                //btn.Click += new EventHandler(clickedLower);
                if (i % 10 == 0) pn_floor.SetFlowBreak(btn, true);
                pn_floor.Controls.Add(btn);
                ++i;
            }
            i = 1;
            foreach (Seat s in th.getUpperSeats())
            {
                Button btn = s.setupButton();
                //btn.Click += new EventHandler(clickedUpper);
                if (i % 8 == 0) pn_upper.SetFlowBreak(btn, true);
                pn_upper.Controls.Add(btn);
                ++i;
            }

            getBuyers(selectedPlayId);
            calcIncome();

        }
    
        private void getBuyers(int playId)
        {
            customers.Clear();
            Dictionary<string, int> income = new Dictionary<string, int>();

            try
            {
                db.openConn();
                dt = new DataTable();
                cmd = new SQLiteCommand(
                    "SELECT vevo,sor,oszlop,kupon_id,h.kategoria,ar FROM VETELEK v " +
                    "JOIN HELYEK h ON v.hely_id = h.id " +
                    "JOIN KATEGORIAK ka ON h.kategoria = ka.kategoria " +
                    "WHERE eloadas_id = " + playId+
                    " ORDER BY vevo", db.GetConnecton()
                    );
                sda = new SQLiteDataAdapter(cmd);
                sda.Fill(dt);
                foreach(DataRow r in dt.Rows)
                {
                    String name = r[0].ToString();
                    String place=r[1].ToString()+"-"+r[2].ToString();
                    int cupon_id = int.Parse(r[3].ToString());
                    String cat = r[4].ToString();
                    int price = int.Parse(r[5].ToString());
                    int payed = price - price * discounts[cupon_id] / 100;
                    Debug.WriteLine(payed);
                    BuyerElement b = new BuyerElement(name, place, cupon_id, cat, payed);
                    customers.Add(b);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
            finally
            {
                db.closeConn();
            }
            dg_buy.DataSource = customers;


        }
    
        private void calcIncome()
        {
            int sumIncome = 0;
            int vipIncome = 0;
            int lowIncome = 0;
            int upIncome = 0;
            foreach(BuyerElement e in customers)
            {
                sumIncome += e.Payed;
                switch (e.Category.ToUpper())
                {
                    case "VIP":
                        vipIncome += e.Payed;
                        break;
                    case "FOLDSZINT":
                        lowIncome += e.Payed;
                        break;
                    case "KARZAT":
                        upIncome += e.Payed;
                        break;
                    default:
                        Debug.WriteLine("Nincs ilyen kategoria: {0}", e.Category);
                        break;
                }
            }

            lb_sumincome.Text = sumIncome.ToString()+" HUF";
            lb_vipincome.Text = vipIncome.ToString() + " HUF";
            lb_lowincome.Text = lowIncome.ToString() + " HUF";
            lb_upincome.Text = upIncome.ToString() + " HUF";
        }
    }
}
