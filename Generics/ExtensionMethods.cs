using System;
using System.Linq;

namespace Generics
{
    public static class ExtensionMethods
    {

        public static string Pluralize(this string s)  
        {
            return (s[^1] == 'y') ? s.Remove(s.Length - 1, 1) + "ies" : s + "s";
        }

        public static T[] SortArray<T>(this T[] array)
        {
            return array.OrderBy(value => value).ToArray();
        }
    }
}
