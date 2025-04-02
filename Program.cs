// 1. WAP to find Second largest element in an array : arr[] = [12, 35, 1, 10, 34, 1, 35], without
// sorting, without using any built-in methods and without deleting duplicate elements. What will be
// the time complexity?
using System;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 12, 35, 1, 10, 34, 1, 35 };
            int secLarge = 0;
            int large = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > large)
                {
                    secLarge = large;
                    large = arr[i];
                }
                if (arr[i] < large && arr[i] > secLarge)
                {
                    secLarge = arr[i];
                }
            }
            Console.WriteLine(secLarge);
        }
    }
}