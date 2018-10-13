using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingProgrammingLesson
{
    static class Demo
    {
        //All the variables and methods have to be static in this class
        //But if it was a normal class, variables and methods can either be staic or normal

            //we use keyword 'public' to make the variables publicly accessible
            //but here we must also add another key word 'static'. Otherwise we get error message
        public static string firstName = "Car";
        public static string lastName = "Key";

        public static void FullName()
        {
            Console.WriteLine("His fullname is " + firstName + "" + lastName);
        }

    }
}
