using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicLibrary.Pcl.Extensions
{
    [TestClass]
    public class CollectionExTest
    {
        [TestMethod]
        public void AddRangeTest()
        {
            var list = new List<int> { 1, 2, 3 };
            list.AddRange(3, 4);
            list.Count.Is(5);
        }
    }
}
