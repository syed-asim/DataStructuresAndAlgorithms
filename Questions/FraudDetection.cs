using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Questions
{
    internal class FraudDetection
    {

        public static void Run()
        {
            string[] trancactions = new string[] { "1 2", "1 3", "1 1", "2 3", "3 1", "1 2" };
            foreach (var u in DectectFraudUsers(trancactions, 4))
            {
                Console.WriteLine(u);
            }
        }

        public static string[] DectectFraudUsers(string[] logs, int limit)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (var log in logs)
            {
                var fragments = log.Split(" ");
                var sUser = map.ContainsKey(fragments[0]);
                var rUser = map.ContainsKey(fragments[1]);

                map[fragments[0]] = sUser ? map[fragments[0]] + 1 : 1;

                if (fragments[0] == fragments[1])
                {
                    continue;
                }
                map[fragments[1]] = rUser ? map[fragments[1]] + 1 : 1;
            }
            return map.Where(u => u.Value >= limit).Select(u => u.Key).ToArray();
        }
    }
}
