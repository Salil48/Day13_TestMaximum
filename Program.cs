using static GenericsTestMax.FindMaximum;

namespace GenericsTestMax
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Test Maximum Problem using Generics");

            Console.WriteLine("Enter which datatype you want 1)Integer 2)Float 3)String :");
            int z = Convert.ToInt32(Console.ReadLine());

            switch (z)
            {
                case 1:
                    Console.WriteLine("Enter the number of elements in array: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] arr = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Enter the number  {0} : ", i);
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    testCases<int> test = new testCases<int>(arr);
                    test.toPrint();
                    break;

                case 2:
                    Console.WriteLine("Enter the number of elements in array: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    double[] arr1 = new double[n1];
                    for (int i = 0; i < n1; i++)
                    {
                        Console.WriteLine("Enter the number  {0} : ", i);
                        arr1[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    testCases<double> test1 = new testCases<double>(arr1);
                    test1.toPrint();
                    break;

                case 3:
                    Console.WriteLine("Enter the number of elements in array: ");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    string[] arr2 = new string[n2];
                    for (int i = 0; i < n2; i++)
                    {
                        Console.WriteLine("Enter the string  {0} : ", i);
                        arr2[i] = Console.ReadLine();
                    }
                    testCases<string> test2 = new testCases<string>(arr2);
                    test2.toPrint();
                    break;

            }
        }


    }
}

