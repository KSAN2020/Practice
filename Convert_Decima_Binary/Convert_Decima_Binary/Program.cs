using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Decima_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int rem = 0;
            int x = 0;
            // string binary = "";
            int[] binary = new int[8];
            number = int.Parse(Console.ReadLine());
            do
            {
                rem = number % 2;
                binary[x] =rem;
                number = number / 2;
                x++;
               // Console.WriteLine(x);
                //Console.ReadLine();
            } while (number > 1);
            binary[x] = number;
            for (x=7; x>=0; x--)
            {
                Console.Write(binary[x]);
              
            }
            //binary = number+ binary;
            
            Console.ReadKey();


        }
    }
}
