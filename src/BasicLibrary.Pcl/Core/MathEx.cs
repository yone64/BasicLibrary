using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLibrary.Pcl.Core
{
    public static class MathEx
    {
        /// <summary>
        /// 数値(source)をある範囲(fromStart~fromEnd)から別の範囲(toStart~toEnd)に変換します。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="fromStart"></param>
        /// <param name="fromEnd"></param>
        /// <param name="toStart"></param>
        /// <param name="toEnd"></param>
        /// <returns></returns>
        public static double Map(this double source, double fromStart, double fromEnd, double toStart, double toEnd)
            => (source - fromStart) / (fromEnd - fromStart) * (toEnd - toStart) + toStart;

        /// <summary>
        /// 数値を指定した範囲に収めます。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public static double Constrain(this double source, double low, double high) => Math.Max(Math.Min(source, high), low);
    }
}
