using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков припенания - ");
            string s = Console.ReadLine();
            char[] sarray = s.ToCharArray();
            Array.Reverse(sarray);
            string s1 = new string(sarray);

            s = s.Replace(" ", string.Empty);
            s1 = s1.Replace(" ", string.Empty);


            {
                if (s == s1) Console.WriteLine("Эта строка полиандром");


                else
                {
                    Console.WriteLine("Эта строка не полиандром");
                }
            }

            Console.WriteLine(s);
            Console.WriteLine(s1);


            Console.ReadKey();

        }
    }
}
