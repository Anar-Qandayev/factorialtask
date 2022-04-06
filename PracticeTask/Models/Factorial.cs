using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeTask.Models
{
    class Factorial
    {
        public int number { get; set; }
        public int FactorialCalculate(int number)
        {
            if (number == 0)
            {
                return 1;

            }
            else if (number<0)
            {
                return -1;
            }
            else
            {
              return number * FactorialCalculate(number - 1);
                    
            }
        }
    }
}
