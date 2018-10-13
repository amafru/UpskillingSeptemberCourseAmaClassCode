using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingProgrammingLesson
{
    class Employee
    {
        public string firstName;
        public string lastName;
        public int age;
        public double salary;

        //this method below is not required by the task. We did it just to add interest to the task
        public void EmployeeDetails()
        {
            Console.WriteLine("His name is " + firstName + " " + lastName);
            Console.WriteLine("He's of age " + age);
            Console.WriteLine("He's on salary " + salary);
        }

        public void Model()//this model has zero parameteters 
        {
            Console.WriteLine("This is Nokia 3310");
        }

        public void Model(string modelName) //This method has one parameter with datatype 'string'
        {
            Console.WriteLine("This is Samsung s9+");
        }
        public void Model (int modelNumber)
        {
            Console.WriteLine("This is Samsung s9+" + modelNumber);
        }

        //The above implementation means that the method 'Model' has been overloaded
        //now let's go back to the WeekFive... class an implement it using an object
    }
}
