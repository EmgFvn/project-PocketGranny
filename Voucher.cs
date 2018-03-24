using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PocketGranny
{
    public class Voucher
    {
        private List<ListVoucher> _shapes = new List<ListVoucher>();

        public List<ListVoucher> NewLists {get {return _shapes;} private set { _shapes = value; } }
        
        //метод вывода на экран

            public void Print()
            {
                foreach (var a in NewLists)
                    Console.WriteLine($"{a.Product.Name} {a.Product.Weight} {a.Date.Date}");
                
            }
    }
}
