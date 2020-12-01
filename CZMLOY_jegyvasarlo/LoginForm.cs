using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CZMLOY_jegyvasarlo
{
    public partial class LoginForm : Form
    {
        DataTable dt = new DataTable();
        SQLiteDataAdapter sda;
        SQLiteCommand cmd;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            try
            {
                cmd = new SQLiteCommand("select type from FELHASZNALOK " +
                    "where username='" + tb_user.Text + "'" +
                    " and pwd='" + tb_pwd.Text + "'", db.GetConnecton());
                sda = new SQLiteDataAdapter(cmd);
                sda.Fill(dt);
                String type = dt.Rows[0][0].ToString();
                switch (type)
                {
                    case "user":
                        UserForm user = new UserForm();
                        user.Show();
                        this.Hide();
                        break;

                    case "admin":
                        AdminForm admin = new AdminForm();
                        admin.Show();
                        this.Hide();
                        break;

                    default:
                        lb_invalid.Text = "Téves felhasználónév vagy jelszó";
                        System.Diagnostics.Debug.WriteLine("FASZ");
                        break;

                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
            }
            finally
            {
                db.closeConn();
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Készítette: Koloh János Krisztián (CZMLOY)\n");
        }
    }
}
