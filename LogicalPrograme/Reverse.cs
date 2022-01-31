using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograme
{
    public class Reverse
    {
        public void Series()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;
            int revr = 0;
            
           
                while (num != 0)
                {
                    rem = num % 10;
                    revr = revr * 10 + rem;
                    num /= 10;
                }
                Console.Write("Reversed Number: " + revr);
          
        }
    }
}
