using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsol.Class
{
    public class Calculator
    {
        public Calculator()
        {
           // Sercice = new Encoder();
        }
        public void Run()
        {
            Console.WriteLine("Enter an expresssion: ");
            var expression = Console.ReadLine();
        }
    }
}
