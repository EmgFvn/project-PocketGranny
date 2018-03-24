/// FullList(Холодильник) - класс холодильник, использует класс PurchasedGood(Проверка(нет)) - купленные товары
/// ListVoucher(Список Чека) - класс список чека, использует класс Voucher(Чек) - класс чек
/// Product(Продукты) - класс продуктов
/// ShopList(Список продуктов) - класс покупок, использует класс Presence(Наличие) - класс продуктов в наличии
/// Voucher(Чек) - класс чек, использует класс Product(Продукты)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PocketGranny
{
    class Program
    {
        static void Main(string[] args)
        {
            Product one = new Product("Молоко", (float)0.5);
            Product two = new Product("Мясо", (float)0.9);
            Voucher Chak = new Voucher();
            Chak.NewLists.Add(new ListVoucher(one,DateTime.Now));
            Chak.NewLists.Add(new ListVoucher(two,DateTime.Now));
            Chak.Print();
            Console.WriteLine(DateTime.Now);
            Console.ReadKey();
        }
    }
}
