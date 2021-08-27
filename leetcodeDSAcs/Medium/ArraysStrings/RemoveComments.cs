using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Medium.ArraysStrings
{

    // example input
    // [public static void Main(string[] args) {\n // comment \n /* test test */ char[] removed..}]

    // declare function removecomments
    /* declare hashset and add comment declarators
     instantiate stringbuilder */
    // instantiate bool flag for each type of comment declarator that is checked to add chars to builder
    // iterate through the char array inputfile
    // if a // encountered, switch flag to false (don't add chars to the new list until \n is encountered)
    // else if /* encountered, switch flag to false to new list until */ is encountered
    // else add chars to the list, checking all flags are true
    // once iteration is complete, convert stringbuilder to string
    // convert string to char array
    // return char array

    class RemoveComments
    {
        public static char[] Run(char[] inputFile)
        {
            StringBuilder sb = new StringBuilder();
            bool addCharsDoubleSlash = true;
            bool addCharsStarSlash = true;

            for (int i = 0; i < inputFile.Length; i++)
            {
                if (inputFile[i] == '/' && inputFile[i + 1] == '/')
                {
                    addCharsDoubleSlash = false;
                    i++;
                }
                else if (inputFile[i] == '/' && inputFile[i + 1] == '*')
                {
                    addCharsStarSlash = false;
                    i++;
                }
                else
                {
                    if (!addCharsDoubleSlash && inputFile[i] == '\n')
                    {
                        addCharsDoubleSlash = true;
                    }
                    else if (!addCharsStarSlash && inputFile[i] == '*' && inputFile[i + 1] == '/')
                    {
                        addCharsStarSlash = true;
                        i++;
                    }
                    if (addCharsDoubleSlash && addCharsStarSlash) sb.Append(inputFile[i]);
                }
            }

            // conversion from list to char[]
            string strOutput = sb.ToString();
            char[] charArrOutput = strOutput.ToCharArray();

            // return char[]
            return charArrOutput;

        }
    }
}


