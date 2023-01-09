namespace GenericsTestMax
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Maximum Problem using Generics");

            int first = 30;
            int second = 50;
            int third = 100;

            int val = FindMaximum.MaximumIntegerNumber(first, second, third);

            Console.WriteLine(" The Maximum integer is " + val);

        }
    }
}
