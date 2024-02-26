/*namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements of the array separated by spaces:");
            string[] inputArray = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(inputArray, int.Parse);

            Console.WriteLine("Enter the rotation value (k):");
            int k = int.Parse(Console.ReadLine());

            RotateArray(array, k);

            Console.WriteLine("Rotated Array:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
        static void RotateArray(int[] arr, int k)
        {
            int n = arr.Length;
            k = k % n;

            ReverseArray(arr, 0, n - 1);
            ReverseArray(arr, 0, k - 1);
            ReverseArray(arr, k, n - 1);
        }

        static void ReverseArray(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}*/



using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a year:");
        int year = int.Parse(Console.ReadLine());

        if (IsLeapYear(year))
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
