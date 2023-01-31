namespace Exercise3
{
    internal class Program
    {
        /*
         * Design a job class for Harold's home services.
         * The class contains four data fields job description:
         * ex, Wash windomws, time in hour to finish, per hour pay rate and total price..
         * include properties to get and set each field except the total, read only (hourly rate * hour)
         * its walue is calculated each time either the hourly fee or the number of hours is set.
         * overload the +operator so that two jobs can be added. the sum of two jobs is 
         * a new job containing the descriptions of both original jobs (joined by and)
         
         */
        static void Main(string[] args)
        {
            Job job1 = new Job("car wash", 5, 15);
            Console.WriteLine($"{job1.TypeOfWork}, {job1.WorkTime}, {job1.HourlyPayment}, {job1.Total}");


            Job job2 = new Job("window washing", 2, 12.50);
            Console.WriteLine($"{job2.TypeOfWork}, {job2.WorkTime}, {job2.HourlyPayment}, {job2.Total}");

            Job job3 = job1 + job2;
            Console.WriteLine($"{job3.TypeOfWork}, {job3.WorkTime}, {job3.HourlyPayment}, {job3.Total}");




            //Job job3 = 

        }
    }
}