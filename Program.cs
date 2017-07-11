using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constraints
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            string b = null;

            Console.WriteLine(GetStringReference(a));
            Console.WriteLine(GetStringValue(a));

            Console.WriteLine(GetStringReference(b));
            Console.WriteLine(GetStringValue(b));

            var array = ArrayExtensions.Generate<string>(5);

            foreach (var t in array)
            {
                if (t == null)
                    throw new ArgumentNullException();
            }

            var list = new List<int>();
            var dict = new Dictionary<string, int>();

        }

        private static string GetStringReference<T>(T value)
        {
            if (value == null)
                return null;
            return value.ToString();
        }

        private static string GetStringValue<T>(T value)
        {
            if (value == null)
                return null;
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
