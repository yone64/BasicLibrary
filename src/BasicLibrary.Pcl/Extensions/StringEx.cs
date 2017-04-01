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

        /// <summary>
        /// 指定された文字列が null または空であるか、空白文字だけで構成されているかどうかを示します。
        /// </summary>
        /// <param name="s">テストする文字列。</param>
        /// <returns>value パラメーターが null または System.String.Empty であるか、value が空白文字だけで構成されている場合は true。</returns>
        public static bool IsNullOrWhiteSpace(this string s) => string.IsNullOrWhiteSpace(s);

        #region ParseDouble
        /// <summary>
        /// 文字列をDoubleに変換します。失敗した場合はnullが返ります。
        /// </summary>
        /// <param name="s">テストする文字列</param>
        /// <returns></returns>
        public static double? ParseDouble(this string s) => double.TryParse(s, out var d) ? d : default(double?);

        /// <summary>
        /// 文字列をDoubleに変換します。失敗した場合は引数で与えられた値が返ります。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static double ParseDouble(this string s, double defaultValue) => double.TryParse(s, out var d) ? d : defaultValue;

        /// <summary>
        /// 文字列をDoubleに変換します。失敗した場合は引数で与えられたデリゲートが評価され返ります。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static double ParseDouble(this string s, Func<double> func) => double.TryParse(s, out var d) ? d : func();
        #endregion

        #region ParseFloat
        /// <summary>
        /// 文字列をFloatに変換します。失敗した場合はnullが返ります。
        /// </summary>
        /// <param name="s">テストする文字列</param>
        /// <returns></returns>
        public static float? ParseFloat(this string s) => float.TryParse(s, out var f) ? f : default(float?);

        /// <summary>
        /// 文字列をFloatに変換します。失敗した場合は引数で与えられた値が返ります。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static float ParseFloat(this string s, float defaultValue) => float.TryParse(s, out var f) ? f : defaultValue;

        /// <summary>
        /// 文字列をFloatに変換します。失敗した場合は引数で与えられたデリゲートが評価され返ります。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static float ParseFloat(this string s, Func<float> func) => float.TryParse(s, out var f) ? f : func();
        #endregion  


        #region ParseInt32
        /// <summary>
        /// 文字列をInt32に変換します。失敗した場合はnullが返ります。
        /// </summary>
        /// <param name="s">テストする文字列</param>
        /// <returns></returns>
        public static int? ParseInt32(this string s) => int.TryParse(s, out var i) ? i : default(int?);

        /// <summary>
        /// 文字列をInt32に変換します。失敗した場合は引数で与えられた値が返ります。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int ParseInt32(this string s, int defaultValue) => int.TryParse(s, out var i) ? i : defaultValue;

        /// <summary>
        /// 文字列をInt32に変換します。失敗した場合は引数で与えられたデリゲートが評価され返ります。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static int ParseInt32(this string s, Func<int> func) => int.TryParse(s, out var i) ? i : func();
        #endregion  

        #region ParseInt64
        /// <summary>
        /// 文字列をInt64に変換します。失敗した場合はnullが返ります。
        /// </summary>
        /// <param name="s">テストする文字列</param>
        /// <returns></returns>
        public static long? ParseInt64(this string s) => long.TryParse(s, out var n) ? n : default(long?);

        /// <summary>
        /// 文字列をInt64に変換します。失敗した場合は引数で与えられた値が返ります。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static long ParseInt64(this string s, long defaultValue) => long.TryParse(s, out var n) ? n : defaultValue;

        /// <summary>
        /// 文字列をInt64に変換します。失敗した場合は引数で与えられたデリゲートが評価され返ります。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static long ParseInt64(this string s, Func<long> func) => long.TryParse(s, out var n) ? n : func();
        #endregion  

        #region ParseDecimal
        /// <summary>
        /// 文字列をDecimalに変換します。失敗した場合はnullが返ります。
        /// </summary>
        /// <param name="s">テストする文字列</param>
        /// <returns></returns>
        public static decimal? ParseDecimal(this string s) => decimal.TryParse(s, out var n) ? n : default(decimal?);

        /// <summary>
        /// 文字列をDecimalに変換します。失敗した場合は引数で与えられた値が返ります。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static decimal ParseDecimal(this string s, decimal defaultValue) => decimal.TryParse(s, out var n) ? n : defaultValue;

        /// <summary>
        /// 文字列をDecimalに変換します。失敗した場合は引数で与えられたデリゲートが評価され返ります。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static decimal ParseDecimal(this string s, Func<decimal> func) => decimal.TryParse(s, out var n) ? n : func();
        #endregion

        #region ParseShort
        /// <summary>
        /// 文字列をShortに変換します。失敗した場合はnullが返ります。
        /// </summary>
        /// <param name="s">テストする文字列</param>
        /// <returns></returns>
        public static short? ParseShort(this string s) => short.TryParse(s, out var n) ? n : default(short?);

        /// <summary>
        /// 文字列をShortに変換します。失敗した場合は引数で与えられた値が返ります。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static short ParseShort(this string s, short defaultValue) => short.TryParse(s, out var n) ? n : defaultValue;

        /// <summary>
        /// 文字列をShortに変換します。失敗した場合は引数で与えられたデリゲートが評価され返ります。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static short ParseShort(this string s, Func<short> func) => short.TryParse(s, out var n) ? n : func();
        #endregion

        #region ParseByte
        /// <summary>
        /// 文字列をByteに変換します。失敗した場合はnullが返ります。
        /// </summary>
        /// <param name="s">テストする文字列</param>
        /// <returns></returns>
        public static byte? ParseByte(this string s) => byte.TryParse(s, out var n) ? n : default(byte?);

        /// <summary>
        /// 文字列をByteに変換します。失敗した場合は引数で与えられた値が返ります。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static byte ParseByte(this string s, byte defaultValue) => Byte.TryParse(s, out var n) ? n : defaultValue;

        /// <summary>
        /// 文字列をByteに変換します。失敗した場合は引数で与えられたデリゲートが評価され返ります。
        /// </summary>
        /// <param name="s"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static byte ParseByte(this string s, Func<byte> func) => Byte.TryParse(s, out var n) ? n : func();
        #endregion

    }
}
