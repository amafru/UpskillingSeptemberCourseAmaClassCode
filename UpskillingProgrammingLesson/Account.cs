using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingProgrammingLesson
{
    class Account //Superclass (ie. the class that contributes the initial variables
    {
        public virtual int Balance()
        {
            return 5;
            Console.WriteLine("The Subclass method returns balance 10");
        }
    }
}
