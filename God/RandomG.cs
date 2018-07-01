using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace God
{
    public static class RandomG
    {
        private static Random roller = new Random();
        private static Random d = new Random();

        public static double RandomNumbers(int minimum,int maximum)
        {
            int m = d.Next(minimum,maximum);
            double toHit = roller.NextDouble();
            return toHit+m;
        }

        public static string RandomName()
        {
            StringBuilder builder = new StringBuilder();            
            char ch;
            for (int i = 0; i < 4; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * this.roller.NextDouble() + 65)));
                builder.Append(ch);
            }            
            return builder.ToString();
        } 
    }
}
