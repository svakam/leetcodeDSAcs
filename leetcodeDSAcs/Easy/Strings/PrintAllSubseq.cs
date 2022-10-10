using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Strings
{
    public class PrintAllSubseq
    {
        public LinkedList<string> Subseq { get; set; }
        public PrintAllSubseq()
        {
            Subseq = new LinkedList<string>();
        }

        public void Run(string str, string subseq = "")
        {
            if (str.Length == 0)
            {
                Subseq.AddLast("\"" + subseq + "\"");
                return;
            }

            Console.WriteLine(str.Substring(1, str.Length - 1));
            Run(str.Substring(1, str.Length - 1), subseq + str[0]); // include the char
            Run(str.Substring(1, str.Length - 1), subseq); // exclude the char
        }
    }
}

// print("ABCD", "")
// print("BCD", "A") 1
// print("CD", "AB") 1
// print("D", "ABC") 1
// print("", "ABCD") 1
// -> ["ABCD"]
// print("", "ABC") 2
// -> ["ABCD", "ABC"]
// print("", "AB") 1
// -> ["ABCD", "ABC", "AB"]
// print("", "A") 2
// -> ["ABCD", "ABC", "AB", "A"]