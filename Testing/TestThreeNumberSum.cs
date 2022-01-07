using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcodeDSAcs.Medium.Arrays;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class TestThreeNumberSum
    {
        [TestMethod]
        public void Test()
        {
            int[] arr = new int[] { 2, 3, 4, 11, 0, -2, 5 };
            LinkedList<int[]> ans = new();
            ans.AddLast(new int[] { -2, 0, 11 });
            ans.AddLast(new int[] { 2, 3, 4 });
            LinkedList<int[]> output = ThreeNumberSum.Run(arr, 9);
            Assert.AreEqual(ans, ThreeNumberSum.Run(arr, 9));
            arr = new int[] { 3, 4, 5 };
            ans = new();
            ans.AddLast(new int[] { 3, 4, 5 });
            Assert.AreEqual(ans, ThreeNumberSum.Run(arr, 12));
            Assert.IsNull(ThreeNumberSum.Run(arr, 10));
        }
    }
}
