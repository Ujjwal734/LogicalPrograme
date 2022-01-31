using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograme
{
    public class FibonacSeries
    {
        public int number;
        public void Fibb()
        {
           int n1 = 0, n2 = 1, n3, i;
           Console.Write(n1 + " " + n2 + " ");
           for (i = 2; i < number; ++i)
           {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
           }
        }
    }
}
