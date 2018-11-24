using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingProgrammingLesson
{
    class WeekFiveToEight
    {
        static void Main()
        {
            //Task 13
            //for-statement
            //Write a computer program to generate numbers between 1 and 20
            //write those numbers to the console

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Task 14
            //for-statement
            //Write a computer program to generate numbers between 1 and 20 by increments of more than 1 at a time 
            //write to the console all the odd numbers
            //Odd numbers are numbers that are divisible by 2 with remainder 1
            //We'll need the modulus operator (%) to complete this task

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //Task 15
            //for-statement
            //Write a computer program to generate numbers between 1 and 20 by increments of more than 1 at a time 
            //write to the console all the even numbers
            //Even numbers are numbers that are divisible by 2 with remainder 0

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Task 16 (Assignment)
            //Write a computer program to generate numbers between 1 and 45
            //Write your 'firstname' to the console if a number is a multiple of 3,
            //Write your 'lastname' to the console if a number is a multiple of 5
            //write your 'firstname + lastnames' to the console if a number is a multle of 3 and 5

            //the usual FOR variable 'i' can be changed into a variable called 'number' if we prefer
            //for (int number = 1; number <= 45; number++)
            //{
            //    //we but the condition statement with the && at the start cuz otherwise numbers like 15, 30 and 45
            //    //would never be called called and 'Ama Fru' written to console. 
            //    //This is because the computer won't bother to check that && statement if placed at the end
            //    //That's because those numbers would have already been multiples of 3 or 5 before so computer won't see
            //    //the need to check that && statement.
            //    //to overcome this as a programmer. Simply move the && statement to the start so computer is forced to 
            //    //check it first before checking the other statements
            //    //This is called "Dealing with unreacheable code" in programming-speak
            //    if (number % 3 == 0 && number % 5 == 0)
            //    {
            //        Console.WriteLine(number + " = Ama Fru");
            //    }
            //    else if (number % 3 == 0)
            //    {
            //        Console.WriteLine(number + " = Ama");
            //    }
            //    else if (number % 5 == 0)
            //    {
            //        Console.WriteLine(number + " = Fru");
            //    }

            //}

            //Task 17
            //Array
            //Let's assume we want to create an collection of 5 students 
            //One way to do it is

            //string firstStudent = "Ama";
            //string secondStudent = "Bisi";
            //string thirdStudent = "Ola";
            //string fourthStudent = "Jide";
            //string fifthStudent = "Kelly";
            //Console.WriteLine(firstStudent);
            //Console.WriteLine(secondStudent);
            //Console.WriteLine(thirdStudent);
            //Console.WriteLine(fourthStudent);
            //Console.WriteLine(fifthStudent);

            //this is not an effecient way of writing an array. Here's a better way

            //string[] students = new string[5] { "Ama", "Bisi", "Ola", "Jide", "Kelly" };

            ////to display all the variables in the array, we use the foreach statement
            ////type 'foreach' and press TAB key twice....

            //foreach (var item in students)

            ////could also be written as
            ////foreach (string temp in students)
            //{
            //    Console.WriteLine(item);
            //    //Console.WriteLine(temp);
            //}

            //Task 18 
            //To print out specific variables from the array

            //string[] students = new string[5] { "Ama", "Bisi", "Ola", "Jide", "Kelly" };

            //foreach (var item in students)
            //{
            //    if (item == "Bisi" || item == "Jide")
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            ////or (To write Bisi, call the array and specify the variable's array index i.e. location. Array positions start at 0
            //Console.WriteLine(students[1]);

            //Task 19
            //Write a computer program to group together list of students' age and write and their individual ages to Console
            //int[] studentsAge = new int[] {34, 33, 40, 47, 50}; 

            //int[] studentsAge = new int[5];
            //studentsAge[0] = 34;
            //studentsAge[1] = 33;
            //studentsAge[2] = 40;
            //studentsAge[3] = 47;
            //studentsAge[4] = 50;
            //foreach (var item in studentsAge)
            //{
            //    Console.WriteLine(item);
            //}

            //Task 20 .......List
            //List is a group of data with similar datatypes but not a fixed length
            //Write a computer program to group together list of students names
            //Remove a few names after you've added them 
            //And add more names to the list before printing them to the console

            //List<string> studentNames = new List<string>() { "Zina", "Ursula", "Willian", "Taofik", "Test", "Browser" };

            ////Remove
            //studentNames.Remove("Test");
            //studentNames.Remove("Browser");

            ////Add
            //studentNames.Add("Nurudeen");
            //studentNames.Add("Eric");
            //studentNames.Add("Sultan");

            ////To see the variables in the list.
            ////implement 'foreach' statement

            //foreach (var item in studentNames)
            //{
            //    Console.WriteLine(item);
            //}

            ////Task  21
            ////List of integers
            ////Write a computer program to group together list of students Ages
            ////Print to console student ages between 20 and 30

            //List<int> studentsAge = new List<int>() { 23,33,34,29,35,21 };

            ////implement foreach-statement to see the data in the list
            //foreach (var item in studentsAge)
            //{
            //    if(item>=20 && item <= 30)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            ////Task 22
            ////Array List
            ////Array list can be used to hold groups of data with different data types
            ////Write a computer program to capture a student attributes
            ////And write those attributes to the console
            ////Attributes e.g. firstname, age, bank account balance, blackOrWhite

            //ArrayList studentAttributes = new ArrayList() { "Lola", 30, 3456.45, true }; //we've captured data of different types

            ////implement foreach to see all the data in the list

            //foreach (var item in studentAttributes)
            //{
            //    Console.WriteLine(item);
            //}

            ////Task 23
            ////Dictionary allows programmers to hold keys and values of a group of data
            ////Dictionary can evolve based on a programmer's need i.e. you can add or remove data from the collection
            ////Write a program to hold both student id and student firstname
            ////print to console only student names
            //Dictionary<int, string> studentsRecord = new Dictionary<int, string>();
            //studentsRecord.Add(1, "Ama");
            //studentsRecord.Add(2, "Bisi");
            //studentsRecord.Add(3, "Olanipekun");
            //studentsRecord.Add(4, "Eric");
            //studentsRecord.Add(5, "Jide");
            //studentsRecord.Add(6, "Mouse");
            //studentsRecord.Remove(6);

            ////implement foreach to print students' first names

            //foreach (var item in studentsRecord)
            //{
            //    //this time around we add a dot "." to the passing statement in Console writeLine and select from the dropdown options based on our need e.g. key, value, etc
            //    Console.WriteLine(item.Value);
            //}

            ////Task 24
            ////While statement
            ////Write a computer program to ask a user to input a number
            ////and print to the console 'Hello World' if the number is less than 5

            //Console.WriteLine("Enter a positive number");
            //int number = Convert.ToInt16(Console.ReadLine());
            //while (number < 5)
            //{
            //    Console.WriteLine("Hello World");
            //    //if we don't put a stopper e.g. 'break' statement, this code will run indefintely and possibly crash the pc
            //    break;
            //}

            ////Task 25
            ////D0-While
            ////Write a computer program to ask a user to input a number
            ////and print to the console 'Hello World' if the number is less than 5

            //Console.WriteLine("Enter a positive number");
            //int number = Convert.ToInt16(Console.ReadLine());

            //do
            //{
            //    Console.WriteLine("Hello World");
            //    break;
            //} while (number<=5);

            ////Task 26
            ////Above question (Task 25) can also be solved using if statement as below
            //Console.WriteLine("Enter a positive number");
            //int number = Convert.ToInt16(Console.ReadLine());
            //if (number <= 5)
            //{
            //    Console.WriteLine("Hello World");
            //}

            ////Task 27 
            ////return and void keywords
            ////use and existing class e.g. 'FirstClass' from this solution to write the following method types
            ////A method that does not return anything (i.e. a 'void' method)
            ////A method that returns a value, use that value for further calculation

            ////To access the methods 'AdditionOfTwoNumbers' and 'MultiplicationOfTwoNumbers' which we've created in first class..
            ////we need to create an object (e.g. 'firstClassObj')... The use that object to exercise the methods
            //FirstClass firstClassObj = new FirstClass();
            //firstClassObj.AdditionOfTwoNumbers();
            //firstClassObj.MultipilicationOfTwoNumbers();

            //var returnedValue = firstClassObj.MultipilicationOfTwoNumbers(); //use 'var' datatype when unsure what the desired data type is
            //Console.WriteLine(returnedValue * returnedValue); // this is possible  in the "Multi..." values only because the "Multi..." method 
            ////does not have the void keyword.


            //Libraries (default, inbuilt and external)

            ////Task 28
            ////Parameter and Argument
            ////Write a computer program which will take two numbers from the user and write sum of those two numbers to console
            ////NOte: Create a method in another class and pass the above values you are getting from the end user
            ////...

            ////We start by going to our other class (we'll use FirstClass) to create our method
            ////then... write our program below

            //Console.WriteLine("Enter first number");
            //double FirstNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //double SecondNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter third number");
            //double ThirdNumber = Convert.ToDouble(Console.ReadLine());

            ////now create an object of 'FirstClass' class and name it sth descriptive like firstClassObj
            //FirstClass firstClassObj = new FirstClass();

            ////now call the method we created in first class

            //firstClassObj.Addition(FirstNumber, SecondNumber, ThirdNumber);

            ////Note: FirstNumber, SecondNumber, ThirdNumber as used here are called Arguments


            ////Task 29
            ////Constructor
            ////This is a method that has the same name as the class
            ////It can be used to set default value(s)
            ////It gets executed first when the method is called or referenced
            ////Write a program to create a constructor in FirstClass

            ////call first constructor
            //FirstClass firstClassObj = new FirstClass();
            ////call second constructor (we can add like '1 to the variable name to make this new obj different
            //FirstClass firstClassObj1 = new FirstClass("Lola");

            ////Task 30
            ////static Class(es), Method(s), Variable(s) etc
            ////An instance of a static class cannot be created
            ////The class has to be called directly to have asccess to its varables, and methods

            ////Write a computer program to create a static class with at least one variable and method in it
            ////Then write a computer program to call those methods and variables from the static class

            ////see class called 'Demo'

            ////to call methods and variables from a static class, WE DO NOT need to create objects
            ////e.g. to call the method "FullName" from 'Demo' class, simply call them as
            //Demo.FullName();

            ////we can create static variables in a normal class and call them
            ////BUT, we can't create normal variables in a static class
            ////Let's try it
            ////Create some static variables in FirstClass and call them
            //FirstClass.fName();


            //Task 31
            //Object Oriented Programming concepts
            //Encapsulation, Polymorphism, Inheritance and Abstraction,

            ////Encapsulation is defined 'as the process of enclosing one or more items within a physical or logical package'. 
            //Encapsulation, in object oriented programming methodology, prevents access to implementation details.
            //https://www.tutorialspoint.com/csharp/csharp_encapsulation.htm

            //Abstraction: Abstraction is one of the principle of object oriented programming. It is used to display only 
            //...necessary and essential features of an object to ouside the world.
            //https://www.onlinebuff.com/article_oops-principle-abstraction-in-c-with-an-example-and-explanation_5.html

            //Inheritance: This is related to two classes where one class inherits attributes from another class
            //To Demo this
            //Write a computer program to capture both Employee and Manage attributes
            //Manager class to inherit from employee class
            //Create an instance (ie object) or Manager class and display to the console the results

            //Manager managerBisi = new Manager();
            ////Remember: We can also assign these variables below using Console.ReadLine();...
            //managerBisi.firstName = "Adebisi";
            //managerBisi.lastName = "Adesina";
            //managerBisi.age = 36;
            //managerBisi.salary = 78564.45;
            //managerBisi.managerialRole = "CEO";
            //managerBisi.EmployeeDetails();
            //managerBisi.ExtraRole();
            ////this works

            //Console.WriteLine(); //this just tells the computer to create an empty space on the screen for us

            ////BUT Remember: Employee class, CAN NOT inherit from Manager class!
            //Employee employeeAma = new Employee();
            //employeeAma.firstName = "Ama";
            //employeeAma.lastName = "Ngwashi Fru";
            //employeeAma.age = 33;
            //employeeAma.salary = 62345.34;
            //employeeAma.EmployeeDetails();


            ////Task 32
            ////Polymorphism (is made up of two concepts 'Overloading' and 'Overriding' 


            ////Task 32: Method overloading (under Polymorphism) 

            //Means more than one methods with the same name, but different signatures
            ////ie. they have different paramenters in them

            ////example: Write a computer program to have 3 methods with the same name and display their differences
            ////...to the console. Use the Employee class

            ////back from Employee class
            //Employee employeeObj = new Employee();
            //employeeObj.Model(); //use the little prompt which appears after you type 'Model()' to assist you in picking a method if needed
            //employeeObj.Model(41);
            //employeeObj.Model("Iphone 6");

            //Console.WriteLine();

            //Task 33
            //Method Overriding (under Polymorphism)
            //
            //https:www.c-sharpcorner.com/UploadFile/0c1bb2/method-oveloading-and-overriding-C-Sharp/
            //Creating a multiple methods in a class with same name but different parameters and types is 
            //called as method overloading.method overloading is the example of Compile time polymorphism 
            //...which is  done at compile time.

            //Use a superclass called 'Account' and a sub class called 'Amount' to demonstrate this



            //Task 34: Read and Write data from Notepad to Console
            //Create a notepad file (called Test) and load it with content 
            //Write a computer program to read the contents from Test notepad
            //and write the contents to the console

            ////The code below is copied from a simple google search and then refactored to be relevant to our code
            //using (var reader = new StreamReader(@"Test.txt"))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null) //!null means 'Don't read any empty lines from the notepad txt'
            //    {
            //        Console.WriteLine(line); //where 'line is the variable name of the datatype string
            //    }
            //}

            
            
        }
    }
}







