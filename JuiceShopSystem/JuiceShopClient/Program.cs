using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuiceShopEntityLayer;
using JuiceShopBusinessLayer;

namespace JuiceShopClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BussinessManager bm = new BussinessManager();
            Console.WriteLine("********ALL THE AVALIABLE JUICE FLAVOURS**********");
            Console.WriteLine("JUICEID\tJUICE_FLAVOUR\tPRICE");
            List<Juice> juicelst = bm.GetallJuiceFlavours();
            foreach (Juice js in juicelst)
            {
                Console.WriteLine("{0}\t{1}\t{2}", js.juiceid, js.juice_flavour, js.price);
            }
            BussinessManager bm1 = new BussinessManager();
            Console.Write("Enter juice_id:");
            int jid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity:");
            int qty = int.Parse(Console.ReadLine());
            bm1.PurchasedJuice(jid, qty);
            Console.WriteLine("Do u want to continue y/n");
            string s = Console.ReadLine();
            string r;
            if(s=="y")
            {
                do
                {
                    BussinessManager bm2 = new BussinessManager();
                    foreach (Juice j in juicelst)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}",j.juiceid, j.juice_flavour, j.price);
                    }
                    Console.WriteLine("Enter the Juice Flavor Id:");
                    int jfid = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the quantity");
                    int Qty = int.Parse(Console.ReadLine());
                    bm1.PurchasedJuice(jfid, Qty);
                    Console.WriteLine("want to continue more y/n");
                    r = (Console.ReadLine());
                } while (r == "y");
            }
            List<JuicePurchased> j1 = bm1.GetallJuicePurchased();
            int sum = 0;
            foreach(JuicePurchased j2 in j1)
            {
                sum = sum + j2.amount;
            }
            Console.WriteLine("Total Purchase:{0}", sum);

        }
    }
}
