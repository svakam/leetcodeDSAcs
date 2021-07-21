using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodeDSAcs.Medium.ArraysStrings
{
    class AlphabetListFB
    {
        // - Prompt

        // Write a function that returns whether a list of strings is sorted given a specific alphabet.
        // A list of N words and the K-sized alphabet are given.


        // input:  words =    ["cat", "bat", "tab"]
        //         alphabet = ['c', 'b', 'a', 't']

        // output: True

        // input:  words =    ["alice", "eve", "bob"]
        //         alphabet = ['a', 'b', 'c', ..., 'z']  # normal (Latin) alphabet

        // output: False

        // def verify_ordering(words: List[str], alphabet: List[str]) -> bool:
        // #    your code here


        // [apple, apply]


        // implement the alphabet list as an array
        // implement the word list as a linked list
        // global variable to keep track of the previous word
        // traverse the word list
        // method to check current word against previous word for order in given alphabet

        // method to compare current and previous word
        // get the first letter of the given current word
        // check if this letter precedes the previous word with respect to the indices of the alphabet array; if so, return false, else return true

        // [car, carrot]
        // [carrot, car]

        bool VerifyOrdering(LinkedList<string> words, string[] alphabetList)
        {
            string previousWord = null;
            foreach (string word in words)
            {
                if (ComparePreviousAndCurrentWords(previousWord, word, alphabetList))
                {

                }


            }
        }

        bool ComparePreviousAndCurrentWords(string previousWord, string word, string[] alphabetList)
        {
            // iterate simultaneously over each string by char index
            // compare char of current word with previous word


            int charIndex = 0;
            int indexOfCharOfPrevWord = alphabetList.GetIndex(previousWord[charIndex]);
            int indexOfCharOfCurrWord = alphabetList.GetIndex(word[charIndex]);

            bool flag = true;
            while (flag)
            {

                if (indexOfCharOfPrevWord > indexOfCharOfCurrWord)
                {
                    return false;
                }

                charIndex++;

                // eve and bob
                // 2 and 2

                // if run out of length, 
                if (charIndex + 1 > prevWord.Length || charIndex + 1 > currWord.Length)
                {
                    flag = false;
                }
            }

            // check to compare just the lengths of the words against each other; if current word longer than previous, return true, else false

        }

        // [car, carrot] => true
        // [carrot, car] 

        // charIndex = 0
        // indexOfCharOfPrevWord = 2
        // indexOfCharOfCurrWord = 2

        // flag = true

        // charIndex = 2
        // indexOfCharOfPrevWord = 18
        // index = 18
        // charIndex = 3

    }
}
