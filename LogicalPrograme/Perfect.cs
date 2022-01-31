using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograme
{
    public class Perfect
    {
        public void Series()
        {
            Console.WriteLine("Enter a number to check for Perfect Number ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i<= num/2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("Perfect Number...");
            }
            else
            {
                Console.WriteLine("Not Perfect Number...");
            }
        }
    }
}
