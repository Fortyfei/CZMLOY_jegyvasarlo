using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;

namespace CZMLOY_jegyvasarlo
{
    public partial class UserForm : Form
    {
        DataTable dt = new DataTable();
        SQLiteDataAdapter sda;
        SQLiteCommand cmd;
        DataBase db = new DataBase();
        Theatre th;
        Customer custormer;

        

        private int selectedPlayId;
        private List<Play> listofPlays=new List<Play>();

        public UserForm()
        {
            InitializeComponent();
            th = new Theatre(db);
            custormer = new Customer(dg_tickets);
            btn_cupon.Click += new EventHandler(cuponClick);
            try
            {
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

        private void cmb_eloadasok_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPlayId = getPlayId(cmb_eloadasok.Text);

            reset();
        }

        private void clickedLower(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Seat s = th.getSeatById(int.Parse(btn.Name));
            Button find = pn_floor.Controls.Find(btn.Name, true).FirstOrDefault() as Button;
            if (s.Free)
            {
                custormer.addSeat(s);
                s.Free = false;
                s.Choosen = true;
                find.BackColor = Color.Yellow;
            }
            else if (s.Choosen)
            {
                custormer.removeSeat(s);
                s.Free = true;
                s.Choosen = false;
                find.BackColor = Color.Green;
            }
            custormer.calcPrice(lb_price);
        }

        private void clickedUpper(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Seat s = th.getSeatById(int.Parse(btn.Name));
            Button find = pn_upper.Controls.Find(btn.Name, true).FirstOrDefault() as Button;
            if (s.Free)
            {
                custormer.addSeat(s);
                s.Free = false;
                s.Choosen = true;
                find.BackColor = Color.Yellow;
            }
            else if (s.Choosen)
            {
                custormer.removeSeat(s);
                s.Free = true;
                s.Choosen = false;
                find.BackColor = Color.Green;
            }
            custormer.calcPrice(lb_price);
        }

        private int getPlayId(string inp)
        {
            String date = inp.Split('-')[0];
            String name = inp.Split('-')[1];
            for(int i = 0; i < listofPlays.Count(); ++i)
            {
                if (date.Equals(listofPlays[i].Date)&&name.Equals(listofPlays[i].Name)){
                    return i+1;
                }
            }
            return 0;
        }

        private void cuponClick(object sender, EventArgs e)
        {
            custormer.getDiscount(tb_coupon.Text);
            custormer.calcPrice(lb_price);
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            custormer.payment(tb_name.Text,selectedPlayId,db);
            reset();
        }

        private void reset()
        {
            List<int> occupied = th.findOccupied(selectedPlayId);
            th.coronaRes(occupied);
            pn_floor.Controls.Clear();
            pn_upper.Controls.Clear();
            int i = 1;
            foreach (Seat s in th.getLowerSeats())
            {
                Button btn = s.setupButton();
                btn.Click += new EventHandler(clickedLower);
                if (i % 10 == 0) pn_floor.SetFlowBreak(btn, true);
                pn_floor.Controls.Add(btn);
                ++i;
            }
            i = 1;
            foreach (Seat s in th.getUpperSeats())
            {
                Button btn = s.setupButton();
                btn.Click += new EventHandler(clickedUpper);
                if (i % 8 == 0) pn_upper.SetFlowBreak(btn, true);
                pn_upper.Controls.Add(btn);
                ++i;
            }
        }
    }
}
