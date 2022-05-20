using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Basics
{
    internal class HasbTableDs
    {
        public static void Run()
        {
            
            Hashtable ht=new Hashtable();
            for (int i = 0; i < 10; i++)
            {
                ht.Add(i, i);
            }
            foreach (var item in ht.Values)
            {
                Console.Write(item);
            }
        }
    }
}
