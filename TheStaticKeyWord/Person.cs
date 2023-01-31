using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStaticKeyWord
{
    internal class Person
    { 
        //Static is for the entire class where as instance is unique for every single instance. 
        // instance, each person has his own name and age in this case.
        // By saying static we mean that it is for the whole class, each instance does not have its own version of it
        // rather there is only one version for it for entire class. And everyone shares that one version.

        public string name; //instance variable
        public int age; //instance variable
      
        public static int Count;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Count++;
        }

        public string Name //Instance property 
        {
            get 
            { 
                return name; 
            }
            set 
            { 
                name= value;
            }
        }
        public int Age
        {
            get 
            { 
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
