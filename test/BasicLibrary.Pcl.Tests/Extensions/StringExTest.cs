using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicLibrary.Pcl.Extensions
{
    [TestClass]
    public class StringExTest
    {
        [TestMethod]
        public void IsNullOrEmptyTest()
        {
            string source = "a";
            source.IsNullOrEmpty().IsFalse();

            source = "";
            source.IsNullOrEmpty().IsTrue();

            source = null;
            source.IsNullOrEmpty().IsTrue();
        }

        [TestMethod]
        public void IsNullOrWhiteSpaceTest()
        {
            string source = "a";
            source.IsNullOrWhiteSpace().IsFalse();

            source = "";
            source.IsNullOrWhiteSpace().IsTrue();

            source = null;
            source.IsNullOrWhiteSpace().IsTrue();

            source = " ";
            source.IsNullOrWhiteSpace().IsTrue();

            // 半角スペース × 2
            source = "  ";
            source.IsNullOrWhiteSpace().IsTrue();

            // 全角スペース
            source = "　";
            source.IsNullOrWhiteSpace().IsTrue();
        }
    }
}
