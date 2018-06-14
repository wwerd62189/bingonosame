using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINGO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("請輸入想要的樂透組數");
            int b = Convert.ToInt32(Console.ReadLine());


            List<int> n = new List<int>();
            for (int i = 1; i < 43; i++)
            {
                n.Add(i);
            }

            
            Random a = new Random();


            for (int c = 1; c <= b; c++)
            {
                Console.WriteLine("第" + c + "組");

                for (int i = 0; i < 6; i++)
                {
                    int r = a.Next(1, n.Count);
                    Console.WriteLine(n[r]);


                    n.RemoveAt(r);
                }
            }
            Console.ReadKey();
        }
    }
}