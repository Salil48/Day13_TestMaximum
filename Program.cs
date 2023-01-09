namespace GenericsTestMax
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Maximum Problem using Generics");

            int[] arr = { 112, 344, 432, 555, 678 };
            FindMaximum<int> generic = new FindMaximum<int>(arr);
            generic.PrintMaxValue();


        }
    }   
}

