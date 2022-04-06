using PracticeTask.Models;
using System;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        { 
            Factorial fc = new Factorial();
            Console.WriteLine("Eded daxil edin");
            fc.number=Convert.ToInt32(Console.ReadLine());
            Console.Write("Factorial=" + fc.FactorialCalculate(fc.number));
          
            
        }
        
    }
}
