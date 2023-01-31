namespace PassingObjectToMethd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Tom", 20);
            Console.WriteLine($"Before: {p1.Name}, {p1.Age}");
            ChangePerson(p1);
            Console.WriteLine($"After: {p1.Name}, {p1.Age}");

            //Another change
            Person p2 = p1;
            p2.Name = "Sandiago";
            Console.WriteLine($"After alter 2: {p1.Name},{p1.Age}");

        }
        public static void ChangePerson(Person p1)
        {
            p1.Name = "Jeff";
            p1.Age = 32;
        }
    }
}