using System;
using System.Collections.Generic;
using System.Linq;

namespace EMailApp.Common.Extensions
{
    /// <summary>
    /// The IEnumerable Extensions
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// The ForEach
        /// </summary>
        /// <typeparam name="T">The T</typeparam>
        /// <param name="source">The Source</param>
        /// <param name="action">The Action</param>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (action == null)
            {
                throw new ArgumentException("The action cannot be null");
            }

            foreach (var item in source)
            {
                action(item);
            }
        }

        /// <summary>
        /// The Batch
        /// </summary>
        /// <typeparam name="TSource">The T Source</typeparam>
        /// <param name="source">The Source</param>
        /// <param name="size">The Size</param>
        /// <returns>The Task Result</returns>
        public static IEnumerable<IEnumerable<TSource>> Batch<TSource>(this IEnumerable<TSource> source, int size)
        {
            int count = (int)Math.Ceiling((double)source.Count() / size);

            for (int i = 0; i < count; i++)
            {
                yield return source.Skip(i * size).Take(size);
            }
        }
    }
}
