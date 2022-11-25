using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_flap
{
    internal class fisica
    {
        private static int g = 10;
        public static int TempSubida(int V)
        {
            double temp = V * 1.41/g;
            return (int)temp;
        }
        public static int Hmax(int V)
        {
        
            double H = (Math.Pow(V, 2) * 0.5) / (2 * g);
            return (int)H;
        }
    }
}
