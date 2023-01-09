namespace GenericsTestMax
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Maximum Problem using Generics");

            string first = "Apple";
            string second = "Banana";
            string third = "Peach";

            string val = FindMaximum.MaximumString(first, second, third);

            Console.WriteLine(" The Maximum string character is " + val);

        }
    }
}
