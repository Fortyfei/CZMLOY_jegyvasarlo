using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CZMLOY_jegyvasarlo
{
    class Seat
    {
        private int id;
        private int pos;
        private int row;
        private int col;
        private String cat;
        private bool free = true;
        private bool choosen = false;

        public Seat(int id, int pos, int row, int col)
        {
            this.id = id;
            this.pos = pos;
            this.row = row;
            this.col = col;
        }

        public Seat(int id, int pos, int row, int col, string cat)
        {
            this.id = id;
            this.pos = pos;
            this.row = row;
            this.col = col;
            this.Cat = cat;
        }

        public bool Free { get => free; set => free = value; }
        public int Id { get => id; set => id = value; }
        public int Pos { get => pos; set => pos = value; }
        public bool Choosen { get => choosen; set => choosen = value; }
        public string Cat { get => cat; set => cat = value; }

        public Button setupButton()
        {
            Button btn = new Button();
            btn.Name = Id.ToString();
            btn.Text = row + "-" + col;
            btn.BackColor = Free ? Color.Green : Color.Red;
            btn.Width = btn.Height = 40;
            return btn;
        }
        public void reset()
        {
            Choosen = false;
            free = true;
        }

        public String getPlace()
        {
            return col + "-" + row;
        }
    }
}
