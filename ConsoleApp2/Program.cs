using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter pointer");
          int k =int.Parse(Console.ReadLine());
            Console.WriteLine("enter five positive integers");
            int[] arr=new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int missingCount = 0;
            int currentNumber = 1;
            int index = 0;

            while (true)
            {
                if (index < arr.Length && arr[index] == currentNumber)
                {
                    index++;
                }
                else
                {
                    missingCount++;
                    if (missingCount == k)
                    {
                        Console.WriteLine($"The {k}-th missing positive integer is: {currentNumber}"); 
                        break;
                    }
                }
                currentNumber++;
            }


        }
    }
}
