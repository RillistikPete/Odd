using System;

namespace SVM_ScratchPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
			int[] arr = new int[100000];
			Console.WriteLine("Print all odd numbers between l and r.");
            Console.WriteLine("Enter first number (l):");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number (r):");
            int r = int.Parse(Console.ReadLine());

			for (i = l; i <= r; i++)
			{
				arr[i] = i;
			}

			Console.WriteLine("Odd numbers: ");
			for (i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 != 0)
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();
        }
    }
}
