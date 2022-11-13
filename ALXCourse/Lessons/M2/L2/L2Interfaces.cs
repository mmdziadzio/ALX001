using ALXCourse.Lessons.M2.L2.Classes;
using ALXCourse.Lessons.M2.L2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourse.Lessons.M2.L2
{
    public class L2Interfaces
    {
        public static void Run()
        {
            IInvoiceGenerator IHello = new PolishHello();
            IHello.SayHallo();
            IHello.SayHallo("Andrzej");
         }
    }
}
