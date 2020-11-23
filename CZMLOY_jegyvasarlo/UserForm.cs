using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Windows.Forms.VisualStyles;

namespace CZMLOY_jegyvasarlo
{
    public partial class UserForm : Form
    {
        DataTable dt = new DataTable();
        SQLiteDataAdapter sda;
        SQLiteCommand cmd;
        DataBase db = new DataBase();
        Theatre th;

        private int selectedPlayId;
        private List<Play> listofPlays=new List<Play>();

        public UserForm()
        {
            InitializeComponent();

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
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
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
            th = new Theatre(db);
            try
            {

                selectedPlayId = getPlayId(cmb_eloadasok.Text);
                DataTable seats = new DataTable();
                cmd = new SQLiteCommand(
                    "SELECT * FROM HELYEK"
                    , db.GetConnecton()
                    );
                sda = new SQLiteDataAdapter(cmd);
                sda.Fill(seats);
                foreach(DataRow r in seats.Rows)
                {
                    int id = int.Parse(r[0].ToString());
                    int pos = int.Parse(r[1].ToString());
                    int row = int.Parse(r[2].ToString());
                    int col = int.Parse(r[3].ToString());
                    String cat = r[4].ToString();
                    Seat s = new Seat(id, pos, row, col, cat);
                    th.addSeat(s);
                }
                }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
            th.setAvailabiity(th.getOccupied(selectedPlayId));
            dgv_zsollye.DataSource = th.getList();

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
    }
}
