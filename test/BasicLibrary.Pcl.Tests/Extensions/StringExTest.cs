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
    }
}
