using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace fruit_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] reel1 = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            string[] reel2 = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            string[] reel3 = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel1, reel2, reel3 };
            int[] spins = new int[] { 5, 7, 6 };

            fruit(reels, spins);
        }

        public static int fruit(List<string[]> reels, int[] spins)
        {
            string[] reel = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            string[] items = new string[] { reels[0][spins[0]], reels[1][spins[1]], reels[2][spins[2]] };
            foreach( var i in items) {
                WriteLine(i);
            }
            if (items[0] == items[1] && items[0] == items[2]) { return (10 - Array.IndexOf(reel, items[0])) * 10; }
            string item = "";
            string extra = "";
            if (items[0] == items[1]) { item = items[0]; WriteLine($"{item} this is the item"); WriteLine($"{extra} this is the extra"); extra = items[2]; }
            if (items[0] == items[2]) { item = items[0]; WriteLine(item);  WriteLine(extra); extra = items[1]; }
            if (items[1] == items[2]) { item = items[1]; WriteLine(item);  WriteLine(extra); extra = items[0]; }
            if (item != "")
            {
                int num = 10 - Array.IndexOf(reel, item);
                if (extra == "Wild") { num = num * 2; }
                WriteLine(num);
                return num;
            }
            WriteLine(0);
            return 0;


        }

        // public static int fruit(List<string[]> reels, int[] spins)
        // {
        // var table = new Dictionary<string, int[]>()
        //     {
        //     {"Wild",new []{100,10,100}},
        //     {"Star",new []{90,9,18}},
        //     {"Bell",new []{80,8,16}},
        //     {"Shell",new []{70,7,14}},
        //     {"Seven",new []{60,6,12}},
        //     {"Cherry",new []{50,5,10}},
        //     {"Bar",new []{40,4,8}},
        //     {"King",new []{30,3,6}},
        //     {"Queen",new []{20,2,4}},
        //     {"Jack",new []{10,1,2}}
        //     };
        // var results = reels.Select(x => x[spins[reels.IndexOf(x)]]).ToList();
        //     if (results.Distinct().Count() == 1)
        //       return table[results[0]][0];
        //     if (results.Distinct().Count() == 2 && results.Count(x => x == "Wild") == 1)
        //       return table[results.First(x => x != "Wild")][2];
        //     if (results.Distinct().Count() == 2)
        //       return table[results[0] == results[1] ? results[0] : results[2]][1];
        //     return 0;
        // }
    }
}
