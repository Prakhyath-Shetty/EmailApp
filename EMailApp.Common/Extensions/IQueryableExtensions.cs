using System;
using System.Linq;

namespace EMailApp.Common.Extensions
{
    /// <summary>
    /// The IQueryable Extensions
    /// </summary>
    public static class IQueryableExtensions
    {
        /// <summary>
        /// The For Each
        /// </summary>
        /// <typeparam name="T">The T</typeparam>
        /// <param name="source">The Source</param>
        /// <param name="action">The Action</param>
        public static void ForEach<T>(this IQueryable<T> source, Action<T> action)
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
    }
}
