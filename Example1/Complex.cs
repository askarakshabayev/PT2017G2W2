using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    // complex number
    class Complex
    {
        public int x, y; // x/y
        /// <summary>
        /// First consctructor
        /// </summary>
        /// <param name="x"> first parameter </param>
        /// <param name="y"> second parameter </param>
        public Complex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine(x + "/" + y);
        }

        public override string ToString()
        {
            return x + "/" + y;
        }

        public Complex Add(Complex b)
        {
            // this -> a
            // b -> b
            Complex c = new Complex(this.x + b.x, this.y + b.y);
            return c;
        }

        public double getDouble()
        {
            return this.x / this.y;
        }

        public static Complex operator +(Complex c1, Complex c2) {
            Complex c = new Complex(c1.x + c2.x, c1.y + c2.y);
            return c;
        }
    }

}
