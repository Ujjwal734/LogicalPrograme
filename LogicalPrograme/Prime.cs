using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograme
{
    public class Prime
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int i;
        public int m = 0;
        public int flag = 0;
        public void Prim()
        {
            m = num / 2;
            for (i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Number is not Prime :- ");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is Prime :- ");

        }
    }
}

