using System;
using System.Collections.Generic;
using System.Linq;

namespace Constraints
{
    internal static class Program
    {
        private static void Main()
        {
            const int a = 1;
            string b = null;

            Console.WriteLine(GetStringReference(b));
            Console.WriteLine(GetStringValue(a));

            Console.WriteLine(GetStringReference(b));
            Console.WriteLine(GetStringValue(a));

            var array = ArrayExtensions.Generate<string>(5);

            if (array.Any(t => t == null))
            {
                throw new ArgumentNullException();
            }

            var list = new List<int>();
            var dict = new Dictionary<string, int>();

        }

        private static string GetStringReference<T>(T value) where T : class 
        {
            return value?.ToString();
        }

        private static string GetStringValue<T>(T value) where T : struct 
        {
            return value.ToString();
        }

        private static void Print<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
