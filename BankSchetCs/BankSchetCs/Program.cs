using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSchetCs
{

    public struct Fio
    {
        public String sName;
        public String fName;
        public String tName;
    }

    class Program
    {
        public static BankSchetClass[] BankSchets = new BankSchetClass[10];
        static void Main(string[] args)
        {
            Random rand = new Random();
            Fio s;
            s.fName = "Arteom";
            s.sName = "Kashitsin";
            s.tName = "Andreyeech";
            for (int i = 0; i < BankSchets.Length; i++)
            {
                BankSchets[i] = new BankSchetClass(DateTime.Now, s, Double.Parse(rand.Next(100, 10000).ToString()), rand.Next(1, 12));
            }
            Console.WriteLine(BankSchets[0].Balance);
            BankSchets[0] = BankSchets[0] % 4.9;
            Console.WriteLine(BankSchets[0].Balance );







           
            Console.ReadKey();
        }
    }
}
