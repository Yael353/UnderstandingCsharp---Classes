namespace Classes
{
    internal class Program
    {
        //Introduction 6: Classes

        // Object; car, person etc.
        // Class; can be explained like a blueprint. a house with a given amount of floors, doors etc is a class, out of it we can do many houses.
        // what functions and actions it can do? and then make an object of that. 
        // 1 more example. Class student, Make an instance of a student and call him student1, and then another one called student2 etc.
        // These students share the same student class. but internal data for all the students will be different. different ages, grades etc. 

        // How to create a class.
        static void Main(string[] args)
        {
            
            //We create a specific object of student class called student1, he has a given name age and final grade.

            //Instansiation when we call "new".
            Student student1 = new Student("Tom", "Thomson", 19, 75); //1 version of student blueprint, we can create how many students we like.
            student1.Name = "";
            Console.WriteLine(student1.Name);
            student1.FinalGrade = 311;
            Console.WriteLine(student1.FinalGrade);
            Console.WriteLine(student1.Name);            
            //Now we can create a new student called student2 with the same blueprint:

            //prop: almost the same as get and set, offers a syntax almost like a variable, but is a function.
            //Instead of calling a method we use the assignment operator. Only for C#

        }
    }
}