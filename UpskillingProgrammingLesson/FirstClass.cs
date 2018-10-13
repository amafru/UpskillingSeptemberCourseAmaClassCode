using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingProgrammingLesson
{
    class FirstClass
    {
        double firstNumber = 20.5;
        int secondNumber = 10;
        //'firstNumber' and secondNumber ar known as class level variables
        //while 'result' below is known as a method level variable.

        public void FirstMethodFirstClass()
        {
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
        }

        public void AdditionOfTwoNumbers()
        {
            double sum = firstNumber + secondNumber;
            Console.WriteLine("Addition of two numbers = " + sum);
        }

        public double MultipilicationOfTwoNumbers()
        {
            double result = firstNumber * secondNumber;
            Console.WriteLine("Multiplication of two numbers = " + result);
            return result;
        }

        //Task 28

        //Note: NumberOne, NumberTwo, NumberThree in the method below are called 'Parameters'
        //When we reference these parameters from another class, they're then called 'Arguments' or 'Passing Argument)

        public void Addition(double NumberOne, double NumberTwo, double NumberThree)
        {
            double Total = NumberOne + NumberTwo + NumberThree;
            Console.WriteLine("Addition of three numbers is " + Total);
        }

        //Task 29
        //Constructor
        //This is a method that has the same name as the class
        //It can be used to set default value(s)
        //It gets executed first when the method is called or referenced

        //constructor 1
        public FirstClass()
        {
            Console.WriteLine("This is a constructor");
        }
        //we don't have to have only one constructor
        //We can create another one. Just make it a bit different by name, or eg by adding Parameters in ()
        public FirstClass(string name)
        {
            Console.WriteLine(name + " This is a constructor");
        }

        //Task 30
        public static void fName()
        {
            Console.WriteLine("His fullname is Ama");
        }
    }
}
