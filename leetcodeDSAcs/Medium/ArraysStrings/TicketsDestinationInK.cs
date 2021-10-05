using System;
using System.Collections.Generic;
using System.IO;

//A Ticket has a Source and a Destination

//A Ticket could look like this:

//{
//  src: "SEA",
//  dest: "SLC"
//}

//An array of Tickets would look like this:

//[{src: "SEA", dest: "BULG"}, {src: "BULG": dest: "DUBAI"}, {src: "SEA", dest: "SLC"}, {src: "SLC", dest: "LAX"}, {src: "SEA", dest: "SLC"}, {src: "SLC", dest: "SEA"}]

//Write a function which takes a Source, Destination, an Array of Tickets, and an integer k, and returns a boolean indicating if it is possible to reach the Destination from the
//Source using exactly k Tickets in the array

// example input: src: SLC, dest: DUBAI, k = 3 --> true
// example input: src: SEA, dest: LAX, k = 4 --> true
// example input: src: SEA, dest: SLC, k = 3 --> false

namespace leetcodeDSAcs.Medium.ArraysStrings
{
    public class TicketsDestinationInK
    {
        public static bool Run(string src, string dest, Ticket[] list, int k)
        {
            List<int> positionsOfTicketsWithInputSrc = new List<int>();
            bool ticketExistsWithInputSrc = false;
            for (int i = 0; i < list.Length; i++)
            { 
                if (list[i].src == src)
                {
                    ticketExistsWithInputSrc = true;
                    positionsOfTicketsWithInputSrc.Add(i);
                }
            }
            if (!ticketExistsWithInputSrc) return false;

            if (k == 1)
            {
                for (int i = 0; i < positionsOfTicketsWithInputSrc.Count; i++)
                {
                    if (list[positionsOfTicketsWithInputSrc[i]].dest == dest) return true;
                }
            }

            HashSet<int> ticketIndicesLookedAt = new HashSet<int>();

            int counter = 1; // if this ever exceeds k or _____, return false
            for (int i = 0; i < positionsOfTicketsWithInputSrc.Count; i++)
            {
                ticketIndicesLookedAt.Add(positionsOfTicketsWithInputSrc[i]); // add this index immediately 
                Ticket ticketInListBeingLookedAt = list[positionsOfTicketsWithInputSrc[i]];
                for (int j = 0; j < list.Length; j++)
                {
                    if (list[j].src == ticketInListBeingLookedAt.dest && ticketIndicesLookedAt.Contains(j))
                    {
                        counter++;
                        ticketInListBeingLookedAt = list[j];
                    }
                }
            }

        }
    }

    public class Ticket
    {
        public string src;
        public string dest;
        public Ticket(string src, string dest)
        {
            this.src = src;
            this.dest = dest;
        }
    }
}


