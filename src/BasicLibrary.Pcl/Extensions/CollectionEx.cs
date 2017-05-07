using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLibrary.Pcl.Extensions
{
    public static class CollectionEx
    {
        /// <summary>
        /// Collectionに追加します。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static T AddTo<T>(this T source, ICollection<T> collection)
        {
            collection.Add(source);
            return source;
        }

        /// <summary>
        /// Collectionに追加します。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="collection"></param>
        public static void AddRange<T>(this ICollection<T> source, IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                source.Add(item);
            }
        }

        /// <summary>
        /// Collectionに追加します。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="collection"></param>
        public static void AddRange<T>(this ICollection<T> source, params T[] collection)
        {
            foreach (var item in collection)
            {
                source.Add(item);
            }
        }
    }
}
