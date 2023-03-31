using GenericDemo;


namespace GenreicDemo
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Generic Program");
            Console.WriteLine("Please Enter the FirstValue:");
            string num1 = Console.ReadLine();
            Console.WriteLine("Please Enter the SecondValue:");
            string num2 = Console.ReadLine();
            Console.WriteLine("Please Enter the ThirdValue:");
            string num3 = Console.ReadLine();
            string val = FindMax.MaximumNum(num1, num2, num3);
            Console.WriteLine("{0} is greater", val);
        }

    }
}
