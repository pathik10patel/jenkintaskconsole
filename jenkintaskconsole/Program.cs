using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jenkintaskconsole
{
    public class Program
    {
        public static int sum()
        {
            int i, sum = 0;
            for (i = 0; i <= 10; i++)
            {
                sum += i;
            }
            //Console.Write("The sum of 10 no is : {0}", sum);
            return sum;
        }

        public static void Main(string[] args)
        {
            int x = sum();
            Console.WriteLine(x);
        }

       
    }

}
