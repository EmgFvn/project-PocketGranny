using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PocketGranny
{
    class Presence
    {
        private Product _product { get; set; }
        private DateTime _date { get; set; }
        public Product Product { get { return _product; } set { _product = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }

        public Presence(Product nameProduct)
        {
            Product = nameProduct;
        }
    }
}
