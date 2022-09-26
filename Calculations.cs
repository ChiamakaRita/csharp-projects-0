using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_projects_0
{
    public class Calculations
    {
        public void EvenNumbers()
        {
            int start = 0;
            while(start <= 10)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        public void Module()
        {
           int num;
           int module;
           Console.WriteLine("Enter a whole number ");
           num = Convert.ToInt32(Console.ReadLine());

           module = num % 2;
           if(module == 0){
            Console.WriteLine("You entered an even Number");
           }else
           Console.WriteLine("You entered an odd Number"); 

        }
    }
}