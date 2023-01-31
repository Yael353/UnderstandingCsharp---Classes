using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Student
    {
        //Fields:

        //Public makes us able to reach public from other classes, if "name was private we would only be able to use it from this class and therefore
        //we would get errors in program.se
        private string name; //Defines that all students will have a name,
        private int age;
        private double finalGrade;
        //We want the fields to be private in order to protect this class so that no one can change anything by accident.
        //Get/set is a controlled way of exposing name, age, final grade(fields)

        //Auto-implemented property
        public string LastName { get; private set; } //By setting private here we protect our data. The name can now no be changed from outside the class

        public Student(string name, string lastName, int age, double finalGrade) //parameter for the class, "You need to give me this in order to use this class".
                                                                //Constructor does not have a return type and is called the same as the class.
        {
            this.name = name;
            this.age = age;
            this.finalGrade = finalGrade;
            this.LastName = lastName;
        }

        public Student(string name, string lastName, int age)
            : this(name, lastName, age, 0)
        {
            //By zero here we create a default value for finalGrade, we can therefore use this
            //ctor to call the one above without having to type "this.name = name; and thus
            //rewrite code.
        }


        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }
        public string Name //Proprs can not have no parameters we need to use "value" instead
        {
            get
            {
                if (age >= 18)
                {
                    return name;
                }
                else
                {
                    return "student younger than 18";
                }
            }
            set
            {
                if (value != "")
                {
                    name = value; //Value represent the value to what we try to set.
                }
            }
        }

        public int Age
        {
            get
            {
                if (age >= 18)
                {
                    return age;
                }
                else
                    return -1;
            }
            set
            {
                if (value != 0)
                {
                    age = value;
                }
            }
        }
        public double FinalGrade
        {
            get
            {
                return finalGrade;
            }
            set
            {
                if (value < 65)
                {
                    value = 65;
                }
                else if (value > 100)
                {
                    value = 100;
                }
                finalGrade = value;
            }


        }

    }

}
