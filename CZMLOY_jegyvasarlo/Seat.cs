using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Seat(int id, int pos, int row, int col)
        {
            this.id = id;
            this.pos = pos;
            this.row = row;
            this.col = col;
        }

        public Seat(int id, int pos, int row, int col, string cat)
        {
            this.Id = id;
            this.pos = pos;
            this.row = row;
            this.col = col;
            this.cat = cat;
        }

        public bool Free { get => free; set => free = value; }
        public int Id { get => id; set => id = value; }
    }
}
