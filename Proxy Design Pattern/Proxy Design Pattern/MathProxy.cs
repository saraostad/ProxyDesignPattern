using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Design_Pattern
{
    /// <summary>
    /// The 'Proxy Object' class
    /// </summary>
    public class MathProxy : IMath
    {
        private Math math = new Math();

        public MathProxy()
        {
            Console.WriteLine("Calling the Math functions via Proxy");
        }

        public double Add(double x, double y)
        {
            Console.WriteLine("Log addition");
            return math.Add(x, y);
        }
        public double Sub(double x, double y)
        {
            Console.WriteLine("Log substraction");
            return math.Sub(x, y);
        }
        public double Mul(double x, double y)
        {
            Console.WriteLine("Log multiplication");
            return math.Mul(x, y);
        }
        public double Div(double x, double y)
        {
            Console.WriteLine("Log division");
            return math.Div(x, y);
        }
    }
}
