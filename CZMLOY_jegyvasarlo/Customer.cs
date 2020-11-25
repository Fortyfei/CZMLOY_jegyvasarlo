using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZMLOY_jegyvasarlo
{
    class Customer
    {
        String name;
        String coupon;
        int discount = 0;
        List<Seat> reserved = new List<Seat>();


        internal List<Seat> Reserved { get => reserved; set => reserved = value; }

        public void addSeat(Seat s)
        {
            Reserved.Add(s);
        }

        public void removeSeat(Seat s)
        {
            Reserved.Remove(s);
        }


    }
}
