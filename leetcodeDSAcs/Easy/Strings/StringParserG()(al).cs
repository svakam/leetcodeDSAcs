using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Easy.Strings
{
    class StringParserGoal
    {
        // runtime: 72 ms, 99.49% faster
        // memory: 23.4 mb, 75.72% less
        public string Interpret(string command)
        {
            // G = G, () = o, (al) = al
            // initialize stringbuilder
            // iterate through string
            // switch case: if "G" is seen, append "G", if "(a" is seen, append "al", else append "o"
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while (i < command.Length)
            {
                switch (command[i])
                {
                    case 'G':
                        sb.Append('G');
                        i++;
                        break;
                    case '(':
                        i++;
                        if (command[i] == 'a')
                        {
                            sb.Append('a').Append('l');
                            i += 3;
                        }
                        else
                        {
                            sb.Append('o');
                            i++; // need to be careful about cursor
                        }
                        break;
                    default:
                        Console.WriteLine("Did not land on an appropriate char. Exit");
                        return null;
                }
            }
            return sb.ToString();
        }
    }
}
