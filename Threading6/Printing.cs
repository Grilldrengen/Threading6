using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading6
{
    public class Printing
    {
        

        private int sum = 0;
        private int amount = 60;
        public void asterisks()
        {
            
            for (int i = 0; i < 60; i++)
            {
                Console.Write("*");  
            }
            math();
            Console.WriteLine();
            

        }

        public void gardenGates()
        {
            
            for (int i = 0; i < 60; i++)
            {
                Console.Write("#");
            }
            math();
            Console.WriteLine();
            
        }

        public void math()
        {
            sum += amount;
            Console.Write(sum);
        }
    }
}
