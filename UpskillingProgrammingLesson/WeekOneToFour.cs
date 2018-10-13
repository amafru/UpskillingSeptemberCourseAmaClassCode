using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingProgrammingLesson
{
    class WeekOneToFour
    {
        static void Main(string[] args)
        {
            //Datatypes or Types (Integer, String, Boolean, Var) (covered)
            //String manipulation (covered)
            //Class(covered)
            //Object (instance (covered) or static)
            //Constructor (covered)
            //Access modifier (private, public, internal) (covered)
            //Method (parameter, argument, return, void) (covered)
            //Object Oriented Programming (Encapsulation (covered), Polymorphism (covered), Inheritance (covered), Abstraction (covered))
            //Try-catch statement (covered)
            //Conditional statements (if, switch-case) (covered)
            //Control statements (for, for-each, while, do-while) (covered)
            //Collections (List, Array, Dictionary) (covered)
            //Concatenation (covered)
            //Read and Write data from Notepad to Console (covered)

            ////Task 1
            //Console.WriteLine("Enter your name ");
            //string name = Console.ReadLine(); //reads data from the console
            //Console.WriteLine("Hello world!"); //writes data to the console
            //Console.WriteLine(name);

            ////Task 2
            //// Identify different data types with examples
            //string firstName = "Ade";  //string - datatype, firstName - variable, 
            //                           //Ade - a value assigned to a variable firstname
            //string value = "5000";  //this is an example of hardcoding 
            //int age = 30;
            //bool isEnabled = true;
            //double money = 23.22;
            //long longNumber = 12345678912;
            //double VAT = 0.2;

            //Value / Values can be from different sources e.g. directly assigned to a 
            // variable - hardcoding, coming from console or user interface,
            // coming from a datasource - like database, XML, Json, CSV, Excel etc


            //Task 3
            //Write a program to add two numbers
            //Remember that any values inputted to the console will be a string even 
            // it is 33 (which to human it's an integer), true (which to human it's a boolean)
            // 22.33 (which to human it's a double). To a computer, it's a string. It needs conversion

            //Console.WriteLine("What's the first number? ");
            //int firstNumber = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("What's the second number? ");
            //int secondNumber = Convert.ToInt16(Console.ReadLine());
            //int total = firstNumber + secondNumber;
            //Console.WriteLine("Addition of two numbers = " + total);

            //Task 4
            //Write a program to calculate the average of 3 numbers 

            //double Average;

            //Console.WriteLine("CALCULATE AVERAGE OF 3 NUMBERS:");
            //Console.WriteLine("_______________________________");
            //Console.WriteLine("Please Enter your First Number: ");
            //double FirstNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please Enter your Second Number: ");
            //double SecondNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please Enter your Third Number: ");
            //double ThirdNumber = Convert.ToDouble(Console.ReadLine());

            //Average = ((FirstNumber + SecondNumber + ThirdNumber) / 3);

            //Console.WriteLine("Average of your 3 numbers is: " + Average);


            //Task 5
            //Write a program to calculate the area of a triangle

            //double Area;

            //Console.WriteLine("Calculate the Area of a Triangle:");
            //Console.WriteLine("________________________");
            //Console.WriteLine("Please enter measurement for the Triangle's base:");
            //double Base = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please enter measurement for the Triangle's height");
            //double Height = Convert.ToDouble(Console.ReadLine());

            //Area = ((Base * Height) / 2);
            //Console.WriteLine("Area of Triangle is: " + Area);

            //Task 6 'try-catch' statement
            //(continuation of task 4. e.g in a case where a the program has been written to 
            //...Conver.ToInt the user's ReadLine entry. And a user tries to enter a number with 
            //...decimals)

            //where you want a program to catch an exception e.g.where a user enters
            //...an unacceptable value. Use the 'Catch exeption procedure below
            //To get the below piece of code, type the word 'try' and press the Tab key twice
            //Type your core piece of code in the curly braces for 'try' and add the exception 
            //...message in the curly braces for 'catch'

            //try//now double tap the Tab key
            {
                //    Console.WriteLine("CALCULATE AVERAGE OF 3 NUMBERS:");
                //    Console.WriteLine("_______________________________");
                //    Console.WriteLine("Please Enter your First Number: ");
                //    double FirstNumber = Convert.ToDouble(Console.ReadLine());
                //    Console.WriteLine("Please Enter your Second Number: ");
                //    double SecondNumber = Convert.ToDouble(Console.ReadLine());
                //    Console.WriteLine("Please Enter your Third Number: ");
                //    double ThirdNumber = Convert.ToDouble(Console.ReadLine());

                //    double Average = ((FirstNumber + SecondNumber + ThirdNumber) / 3);

                //Console.WriteLine("Average of your 3 numbers is: " + Average);
            }

            //catch (Exception)
            //catch (Exception e) 
            //We can either leave the passing argument as just 'Exception' and then
            //type a specific error msg to display in Console OR use 'Exception e' and instead of 
            //specifying a message to print to console, rely on the computer to throw up it's own 
            //error message by assing the passing argument 'e.Message' to Console WriteLine as below
            {
                //console.writeline("the value entered is incorrect. please type a number");
                //console.writeline(e.message);
            }

            //Task 7
            //Write a computer program to print 1 to 9 to the console
            //Put all the code in this Main method

            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");

            //Task 8
            //Write a computer program to print 1 to 9 to the console
            //Put your code in this program class
            //Split your code accross 3 methods and call those methods from the Main method

            //FirstMethod();
            //SecondMethod();
            //ThirdMethod();

            //Task 9
            //Remember the concept of 'Access Modifiers' 
            //Access modifiers can either be 'Private' or 'Public' and it works for variables, methods and classes
            //Variables and methods to be visible from another class have to be made 'Public'
            //They are 'Private' by default

            //Write a computer program to print 1 to 9 to the console
            //Put your code in 3 different methods which belong to 3 different classes
            //Make sure that the method from each class gets reference from the Main method
            //P.S: See sub classes 'FirstClass', 'SecondClass' & 'ThirdClass'

            //Hint: An object is an instance of a class while a class is the blueprint for an object

            //below is how we create an object to reference First Class

            //FirstClass firstClassObj = new FirstClass();
            //SecondClass secondClassObj = new SecondClass();
            //ThirdClass thirdClassOnj = new ThirdClass();
            //firstClassObj.FirstMethodFirstClass();
            //secondClassObj.SecondMethodSecondClass();
            //thirdClassOnj.ThirdMethodThirdClass();

            //Task 10
            //'If' statement (Conditional statement)

            /*Keep in mind the relevant 'Operators' which are shown below
             * Plus => +
             * Minus => -
             * Multiplication => *
             * Division => /
             * Modulus => %
             * Assignment sign => =
             * Equality sign => ==
             * Or-statement => ||
             * And-statement => &&
             * Greater than => >
             * Less than => <
             * Greater than or equal to => >=
             * Less than or equal to => <=            */

            //Write a computer program to ask a user to input a number
            //Display 'Yes' to the console if the number is greater than 10
            //Display 'No' to the console is the number is less than 10
            //Display 'Equal' to the console if the number is equal to 10

            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt16(Console.ReadLine());

            ////Type 'if' and press Tab key twice to get Code Snipet for 'if' statement

            //if (number > 10)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else if (number < 10)
            //{
            //    Console.WriteLine("No");
            //}
            //else if (number == 10)
            //{
            //    Console.WriteLine("Equal");
            //}

            //{

            //}
            //END OF TASK 10


            //Task 11
            //Create a Programe to accept input of browser choice and print message to console using 'switch-case' statement

            //Console.WriteLine("Please enter a browser name");
            //string browserName = Console.ReadLine().ToLower();//ToLower ensures that even is user enters choice in, say, all uppercase, the program will still take it
            //switch (browserName)
            //{
            //    case "chrome":
            //        Console.WriteLine("Chrome browser will be used to run test");
            //        break;
            //    case "firefox":
            //        Console.WriteLine("Firefox browser will be used to run test");
            //        break;
            //    case "safari":
            //        Console.WriteLine("Safari browser will be used to run test");
            //        break;
            //    case "ie":
            //        Console.WriteLine("IE browser will be used to run test");
            //        break;
            //    default:
            //        Console.WriteLine("Opera as a default browser will be used to run tests");
            //        break;
            }


            //Task 12
            //Programe for a user to input their country and discover their continent of origin
            

            


        //    static void FirstMethod()
        //{
        //        Console.WriteLine("1");
        //        Console.WriteLine("2");
        //        Console.WriteLine("3");
        //    }

        //    static void SecondMethod()
        //{
        //        Console.WriteLine("4");
        //        Console.WriteLine("5");
        //        Console.WriteLine("6");
        //    }

        //    static void ThirdMethod()
        //{
        //        Console.WriteLine("7");
        //        Console.WriteLine("8");
        //        Console.WriteLine("9");
        //    }
        }
    }
}
    







