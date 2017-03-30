using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLibrary.Pcl.Extensions
{
    /// <summary>
    /// Stringに対する拡張メソッド集
    /// </summary>
    public static class StringEx
    {
        /// <summary>
        /// 指定された文字列が null または System.String.Empty 文字列であるかどうかを示します。
        /// </summary>
        /// <param name="s">テストする文字列。</param>
        /// <returns>パラメーターが null または空の文字列 ("") の場合は true。それ以外の場合は false。</returns>
        public static bool IsNullOrEmpty(this string s) => string.IsNullOrEmpty(s);
    }
}
