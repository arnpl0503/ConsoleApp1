namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENter the pieces of apple: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter total price of 6 apple(s): ");
            double Price = Convert.ToDouble(Console.ReadLine());
            int price = (int)Price;
            Console.WriteLine("The total price of 6 apple(s) is: " + Price);
            Console.WriteLine("The value of original price is: " + price);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
