using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1/2 3/4 2/5
            string inp = Console.ReadLine(); // s = "1/2 3/4"
            string[] arr = inp.Split(); // arr[0] = "11/22", arr[1] = "3/4"

            Complex sum = new Complex(0, 0);
            foreach (string s in arr)
            {
                // s = "11/22"
                string[] t = s.Split('/'); // t[0] = 11 t[1] = 22 
                Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                sum = sum + p;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
