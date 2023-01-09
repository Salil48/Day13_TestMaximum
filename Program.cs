namespace GenericsTestMax
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Maximum Problem using Generics");

            float first = 2.6f;
            float second = 2.3f;
            float third = 3.3f;

            float val = FindMaximum.MaximumFloatNumber(first, second, third);

            Console.WriteLine(" The Maximum float value is " + val);

        }
    }
}
