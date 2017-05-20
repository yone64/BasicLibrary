using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLibrary.Pcl.Extensions
{
    public static class ObjectEx
    {
        /// <summary>
        /// Actionを実行します。
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="action"></param>
        public static void Invoke<T>(this T obj, Action<T> action) => action(obj);

        /// <summary>
        /// Funcを実行します。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <param name="obj"></param>
        /// <param name="func"></param>
        public static V Invoke<T, V>(this T obj, Func<T, V> func) => func(obj);

    }
}
