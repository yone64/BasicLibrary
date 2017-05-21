using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicLibrary.Pcl.Extensions
{
    [TestClass]
    public class ObjectExTest
    {
        [TestMethod]
        public void InvokeTest()
        {
            string str = null;

            str?.Invoke(s => Console.WriteLine(s));
            
            int sum = 0;
            int? a = null;
            int? b = 1;

            a?.Invoke(i => sum =+ i);
            b?.Invoke(i => sum = +i);
            
            //if (a != null) sum += a.Value;
            //if (a is int i) sum += i;
            sum.Is(1);
        }
    }
}
