using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseFormApp.Exceptions
{
    public class ThrowExceptionExample
    {
        public void Run()
        {
            MessageBox.Show("Throwing exception");
            throw new OuerOwnException("Dont Click This Button");
        }
            
    }
}
