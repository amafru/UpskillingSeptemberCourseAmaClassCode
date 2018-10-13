using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingProgrammingLesson
{
    class Amount : Account //subclass (the class that draws attributes from the the Superclass
    {
        public override int Balance()
        {
            return 10; //this instruction asks this method to override what is defined in the superclass
            Console.WriteLine("The Subclass method returns balance 10");
        }
    }
}
