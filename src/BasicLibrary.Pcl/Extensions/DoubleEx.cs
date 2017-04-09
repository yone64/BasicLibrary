using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLibrary.Pcl.Extensions
{
    public static class DoubleEx
    {
        /// <summary>
        /// 指定された数値が非数値かどうかを示す値を返します。
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool IsNaN(this double d) => double.IsNaN(d);

        /// <summary>
        /// 指定された値が正または負の無限大と評価されるどうかを示す値を返します。
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool IsInfinity(this double d) => double.IsInfinity(d);
    }
}
