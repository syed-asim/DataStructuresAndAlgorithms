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
            // Transactions log; "1 2 $10" => "senderId receiverId amount"
            string[] trancactions = new string[] { "1 2 $10", "1 3 $20", "1 1 $50", "2 3 $30", "3 1 $31", "1 2 $12" };
            var thrashold = 3;
            Console.WriteLine($"Fraud Detection started, thrashold value= {thrashold}");
            foreach (var u in DectectFraudUsers(trancactions, thrashold))
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
            return map.Where(u => u.Value >= limit).Select(u => $"User ID: {u.Key}, # of transaction: {u.Value}").ToArray();
        }
    }
}
