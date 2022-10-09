using System;
using System.Collections.Generic;
using leetcodeDSAcs.Easy.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestClass]
    public class TestPrintAllSubseq
    {
        [TestMethod]
        public void Test()
        {
            PrintAllSubseq soln = new();
            soln.Run("ABCD");
            LinkedList<string> results = soln.Subseq;
            foreach (string s in results)
            {
                Console.WriteLine(s);
            }
        }

    }
}
