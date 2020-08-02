using System;
using System.Collections.Generic;
using System.Text;

namespace NoSenseTask
{
    public static class Extensions
    {
        public static T ThisDoesntMakeAnySense<T>(this IEnumerable<T> data, Func<T, bool> predicate, Func<T> Creator)
        {
            foreach (T value in data)
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                if (predicate(value))
                {
                    return value;
                }
            }
            return Creator();
        }


    }
}
