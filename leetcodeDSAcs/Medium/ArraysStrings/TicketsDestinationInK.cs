//using System;
//using System.Collections.Generic;
//using System.IO;
///*

//A Ticket has a Source and a Destination

//A Ticket could look like this:

//{
//  src: "SEA",
//  dest: "SLC"
//}

//An array of Tickets would look like this:

//[{src: "SEA", dest: "BULG"}, {src: "BULG": dest: "DUBAI"}, {src: "SEA", dest: "SLC"}, {src: "SLC", dest: "LAX"}, {src: "SEA", dest: "SLC"}, {src: "SLC", dest: "SEA"}]

//src: SEA
//dest: BULG

//src: BULG
//dest: DUBAI
//k = 2

//// reset starting
//src: SEA
//dest: SLC

//Write a function which takes a Source, Destination, an Array of Tickets, and an integer k, and returns a boolean indicating if it is possible to reach the Destination from the Source using exactly k Tickets in the array.
//*/

//public class Ticket
//{
//    public string Src { get; set; }
//    public string Dest { get; set; }
//}

//public class CurrentLocAndFlights
//{
//    public string CurrentSrc { get; set; }
//    public string CurrentDest { get; set; }
//    public int NumTimesFlown { get; set; }
//}

//class Solution
//{
//    bool[] StartingTicketsViewed { get; set; } // tracker for possibilities of starting tickets; false if not tried yet, true if tried

//    // wrapper function to take in ticket list, src/dest, and requested number of flights
//    public bool IsPossibleToFlyByK(string src, string dest, Ticket[] tickets, int k)
//    {
//        CurrentLocAndFlights c = new CurrentLocAndFlights()
//        {
//            NumTimesFlown = 0
//        };
//        return CheckReachDestination(src, dest, tickets, k, c);
//    }

//    // run through ticket list and get counter going on number of times flown
//        // if number of times flown exceeds k, try again with new starting ticket
//        // if number of times flown meets k and match on destination, return true
//    // if no starting ticket, return false
//    public bool CheckReachDestination(string src, string dest, Ticket[] tickets, int k, CurrentLocAndFlights c)
//    {
//        // if starting ticket is available, set the starting ticket
//        for (int i = 0; i < tickets.Length; i++)
//        {
//            // if ticket source match and never seen before, set current location; if destination and number of flights matched, return true
//            if (tickets[i].Src == src && StartingTicketsViewed[i] == false)
//            {
//                StartingTicketsViewed[i] = true;
//                c.CurrentSrc = tickets[i].Src;
//                c.CurrentDest = tickets[i].Dest;

//                if (c.CurrentDest == dest) return true;
//                else
//                {
//                    return CheckReachDestination(src, dest, tickets, k, c);
//                }
//            }
//            else return false; // no source match, or all possible tickets looked at
//        }
//    }
//}
