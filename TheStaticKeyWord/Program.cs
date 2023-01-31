namespace TheStaticKeyWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ted", 24); // Instance of Person
            Person p2 = new Person("Fred", 44);


            //Console is a class, and WriteLine is static.
        
            Console.WriteLine(Person.Count);


            Test();
        }

        public static void Test() //this must be static in order to be called in main, main cant see it if its not for the whole class,
                                  // static can only see static, therefore we do instances within static like above.
        {
            Console.WriteLine("test");
        }
    }
}