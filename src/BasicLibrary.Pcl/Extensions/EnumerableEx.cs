using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLibrary.Pcl.Extensions
{
    public static class EnumerableEx
    {
        /// <summary>
        /// 列挙可能型が要素を持っているかを判断します。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsEmpty<T>(this IEnumerable<T> source) => !source.Any();

        /// <summary>
        /// 列挙可能型がNullまたは要素がない状態かを判断します。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source) => source == null || source.IsEmpty();
    }
}
