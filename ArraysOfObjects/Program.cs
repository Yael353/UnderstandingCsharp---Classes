namespace ArraysOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[2];
            myArray[0] = 5;
            myArray[1] = 10;

            Person[] peopleArray = new Person[2];
            peopleArray[0] = new Person("Bob", 5);
            peopleArray[1] = new Person("test", 6);

            for (int i = 0; i < peopleArray.Length; i++)
            {
                Console.WriteLine("{0},{0}", peopleArray[i].Name, peopleArray[i].Age);
            }
        }
    }
}