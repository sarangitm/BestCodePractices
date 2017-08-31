using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestCodePractices.ExtensionMethods
{
    public static class ListExtensions
    {
        public static bool IsFirst<T>(this List<T> list, T item)
        {
            return (list.IndexOf(item) == 0);
        }

        public static bool IsLast<T>(this List<T> list, T item)
        {
            return list.LastIndexOf(item).Equals(list.Count - 1);
        }
    }
}