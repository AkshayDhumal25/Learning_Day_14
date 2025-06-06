﻿// 1. WAP to find Second largest element in an array : arr[] = [12, 35, 1, 10, 34, 1, 35], without
// sorting, without using any built-in methods and without deleting duplicate elements. What will be
// the time complexity?
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = { 12, 35, 1, 10, 34, 1, 35 };
//            int secLarge = 0;
//            int large = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] > large)
//                {
//                    secLarge = large;
//                    large = arr[i];
//                }
//                if (arr[i] < large && arr[i] > secLarge)
//                {
//                    secLarge = arr[i];
//                }
//            }
//            Console.WriteLine(secLarge);
//        }
//    }
//}


// 2. WAP to reverse an integer without converting it to a string, without using any built-in methods.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int n = 123;
//            int reversed = 0;
//            while (n > 0)
//            {
//                int reminder = n % 10;
//                reversed = reminder + reversed * 10;
//                n /= 10;
//            }
//            Console.WriteLine(reversed);
//        }
//    }
//}


// 2. Swap Values without using any variable a=10, b=12.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int a = 10;
//            int b = 12;

//            a = a + b;
//            b = a - b;
//            a = a - b;

//            Console.WriteLine($"A: {a} and B:{b}");
//        }
//    }
//}


// 3. Logic for anagram program with its time complexity. (for large strings).
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str1 = "listen";
//            string str2 = "silemt";

//            if (isAnagram(str1, str2))
//            {
//                Console.WriteLine("Anagram");
//            }
//            else
//            {
//                Console.WriteLine("Not Anagram");
//            }
//        }

//        public static bool isAnagram(string str1, string str2)
//        {
//            int[] array = new int[256];
//            for (int i = 0; i < str1.Length; i++)
//            {
//                array[str1[i]]++;
//                array[str2[i]]--;
//            }
//            foreach (var i in array)
//            {
//                if (i != 0)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//    }
//}

// 4. Find the reverse of the string.
//using System;
//using System.Collections.Generic;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "Akshay";
//            var reversed = "";
//            for (int i = str.Length - 1; i >= 0; i--)
//            {
//                reversed += str[i];
//            }
//            Console.WriteLine(reversed);
//        }
//    }
//}


// 5. WAP to find missing elements from the array?
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = { 1, 2, 4, 5, 6, 7, 8, 10 };
//            int max = array.Max();
//            int min = array.Min();

//            var list = new List<int>(array);
//            for (int i = min; i < max; i++)
//            {
//                if (!list.Contains(i))
//                {
//                    Console.WriteLine(i + " ");
//                }
//            }
//        }
//    }
//}


// 6. WAP to find the given string is Palindrome or not.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "abba";
//            if (isPalindrome(str))
//            {
//                Console.WriteLine("Palindrome");
//            }
//            else
//            {
//                Console.WriteLine("Not Palindrome");
//            }
//        }
//        public static bool isPalindrome(string str)
//        {
//            int left = 0;
//            int right = str.Length - 1;
//            while (left < right)
//            {
//                if (str[left] != str[right])
//                {
//                    return false;
//                }
//                left++;
//                right--;
//            }
//            return true;
//        }
//    }
//}

// 7. WAP to print Fibonacci series with recursion.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number to get the fibonacci series : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine(fibo(i));
//            }
//        }

//        public static int fibo(int n)
//        {
//            if (n <= 1) return n;
//            return fibo(n - 1) + fibo(n - 2);
//        }
//    }
//}

// 8. WAP to print Fibonacci series without recursion.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number to get the fibonacci series : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            int a = 0;
//            int b = 1;
//            int c = 0;
//            if (n >= 1)
//            {
//                Console.WriteLine(a); // Print the first number (0)
//            }
//            if (n >= 2)
//            {
//                Console.WriteLine(b); // Print the second number (1)
//            }
//            for (int i = 2; i < n; i++)
//            {
//                c = a + b;
//                Console.WriteLine(c + " ");

//                a = b;
//                b = c;
//            }
//        }
//    }
//}

// 11. Find prime numbers from 1 ....n
//using System;
//using System.Linq;
//using System.Collections.Generic;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number to get the Prime Numbers : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            var list = new List<int>();
//            for (int i = 2; i < n; i++)
//            {
//                if (isPrime(i))
//                {
//                    list.Add(i);
//                }
//            }
//            foreach (var i in list)
//            {
//                Console.WriteLine(i);
//            }
//        }
//        public static bool isPrime(int n)
//        {
//            if (n < 2) return false;
//            if (n == 2) return true;
//            if (n % 2 == 0) return false;
//            for (int i = 3; i * i < n; i += 2)
//            {
//                if (n % i == 0)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//    }
//}

// 12. WAP for getting a square root of a given number.
//using System;
//namespace logicals
//{
//    class Prime
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number : ");
//            double n = Convert.ToInt32(Console.ReadLine());
//            double res = Math.Sqrt(n);
//            Console.WriteLine(res);
//        }
//    }
//}


// 14. [80, 60, 10, 50, 30, 100, 0, 50]
// Find pairs whose sum = 100;
// Logic for above problem?
// What will be the complexity for it?
// Any better solution for the above problem?
//using System;
//using System.Collections.Generic;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = { 80, 60, 10, 50, 30, 100, 0, 50 };
//            int targetSum = 100;

//            var list = new List<int>(array);
//            for (int i = 0; i < array.Length; i++)
//            {
//                int complement = targetSum - array[i];
//                if (list.Contains(complement))
//                {
//                    Console.WriteLine($"{complement}  and {array[i]}");
//                }
//            }
//        }
//    }
//}

//Generics
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the 1st element: ");
//            var a = Console.ReadLine();
//            Console.WriteLine("Enter the 2nd element: ");
//            var b = Console.ReadLine();
//            swap(ref a, ref b);
//            Console.WriteLine($"A: {a} and B: {b}");
//        }

//        public static void swap<T>(ref T a, ref T b)
//        {
//            var temp = a;
//            a = b;
//            b = temp;
//        }
//    }
//}

// Find missing number
using System;
using System.Linq;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 6 };
            int n = array.Length + 1;
            int realSum = n * (n + 1) / 2;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(realSum - sum);
        }
    }
}
