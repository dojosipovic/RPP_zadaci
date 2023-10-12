using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem
{
    public class VoteRepository
    {
        public static List<String> voted = new List<String>();
        public static Dictionary<String, Int16> options = new Dictionary<String, Int16>()
        {
            { "FOR", 0 },
            { "AGAINST", 0 },
            { "ABSTAINED", 0 }
        };
        public static bool isVoted(string oib) => voted.Contains(oib);
        public static void addOIB(string oib) => voted.Add(oib);
    }
}
