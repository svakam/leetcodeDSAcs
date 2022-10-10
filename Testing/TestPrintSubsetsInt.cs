using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcodeDSAcs.Medium.Arrays;

namespace Testing
{
    [TestClass]
    public class TestPrintSubsetsInt
    {
        [TestMethod]
        public void Test()
        {
            int[] arr = { 1, 2 };
            Console.WriteLine(arr);
            PrintSubsetsOfSet soln = new();
            soln.Run(arr);
            var results = soln.Output;
            foreach (int[] array in results)
            {
                Console.WriteLine(array.ToString());
            }

            // expect:
            // [null,null], [1,null], [1,2], [null,2]
            //int[] arr2 = { 1, 2, 3 };
            //soln.Run(arr2);
            //results = soln.Output;
            //foreach (int[] array in results)
            //{
            //    Console.WriteLine(array.ToString());
            //}
            // expect:
            // [null,null,null],[1,null,null],[1,2,null],[1,2,3],[1,null,3],
            // [null,2,null],[null,2,3],
            // [null,null,3]
        }
    }
}
