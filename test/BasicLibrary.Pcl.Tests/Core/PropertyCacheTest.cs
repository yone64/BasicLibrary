using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicLibrary.Pcl.Core
{
    [TestClass]
    public class PropertyCacheTest
    {
        [TestMethod]
        public void GetGetterTest()
        {
            var f = new Hoge { Fuga = 1 };
            var func = PropertyCache<Hoge>.GetGetter(o => o.Fuga);
            func(f).Is(1);
        }

        [TestMethod]
        public void GetSetterTest()
        {
            var f = new Hoge { Fuga = 2 };
            var act = PropertyCache<Hoge>.GetSetter(o => o.Fuga);
            act(f, 10);
            f.Fuga.Is(10);
        }
    }

    public class Hoge
    {
        public int Fuga { get; set; }
    }
}
