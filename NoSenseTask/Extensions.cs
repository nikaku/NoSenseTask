using System;
using System.Collections.Generic;
using System.Text;

namespace NoSenseTask
{
    public static class Extensions
    {
        public static T ThisDoesntMakeAnySense<T>(this IEnumerable<T> data, Func<T, bool> predicate, Func<T> Creator)
        {
            if (predicate == null || Creator == null)
            {
                throw  new ArgumentNullException();
            }
            foreach (T value in data)
            {
                if (predicate(value))
                {
                    return default(T);
                }
            }
            return Creator();
        }


    }
}
