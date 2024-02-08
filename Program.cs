namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter the total number of your courses:");
            int courses;
            courses = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price of your favorite book:");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Name:" + name);
            Console.WriteLine("Total enrolled courses:" + courses);
            Console.WriteLine("Price of my favorite book:" + price);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();                                           
        }
    }
}