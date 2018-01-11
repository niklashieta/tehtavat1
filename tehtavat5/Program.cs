using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtavat5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Annappas sekuntteja\n>");
            int seconds = int.Parse(Console.ReadLine());
            Console.Write("hh.mm.ss\n");
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            Console.WriteLine(t.ToString());

           // t = TimeSpan.FromSeconds(868693412);
           // Console.WriteLine(t.ToString());






            /* Console.Write("Give seconds\n>");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = number1 / 60;
            int number3 = number2 / 60;

            Console.Write("Seconds can be shown as ");
            Console.Write( number3 );
            Console.Write(" Hour ");
            Console.Write(number2);
            Console.Write(" minute ");
            Console.Write(number1);
            Console.Write(" second ");*/


        }
    }
}
