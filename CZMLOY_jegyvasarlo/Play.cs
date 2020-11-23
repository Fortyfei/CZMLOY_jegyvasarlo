using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZMLOY_jegyvasarlo
{
    class Play
    {
        private int id;
        private String date;
        private String name;

        public Play(int id,string date, string name)
        {
            this.Id = id;
            this.Date = date;
            this.Name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
        public string Name { get => name; set => name = value; }

        public String printOut()
        {
            return Date + "-" + Name;
        }
    }
}
