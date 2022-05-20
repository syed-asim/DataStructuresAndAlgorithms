using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Basics
{
    public class MinHeap
    {
        public MinHeap(int[] input, int length)
        {

            this.Length = length;
            this.Array = input;
            BuildMinHeap();
        }

        public int[] Array
        {
            get; private set;
        }

        public int Length
        {
            get; private set;
        }

        private void BuildMinHeap()
        {
            for (int i = this.Length / 2; i > 0; i--)
            {
                MinHeapify(i);
            }

            return;
        }

        public void MinHeapify(int index)
        {
            var left = 2 * index;
            var right = 2 * index + 1;

            int Min = index;
            if (left <= this.Length && this.Array[left - 1] < this.Array[index - 1])
            {
                Min = left;
            }

            if (right <= this.Length && this.Array[right - 1] < this.Array[Min - 1])
            {
                Min = right;
            }

            if (Min != index)
            {
                int temp = this.Array[Min - 1];
                this.Array[Min - 1] = this.Array[index - 1];
                this.Array[index - 1] = temp;
                MinHeapify(Min);
            }

            return;
        }

        public int RemoveMinimum()
        {
            int Minimum = this.Array[0];

            this.Array[0] = this.Array[this.Length - 1];
            this.Length--;
            MinHeapify(1);
            return Minimum;
        }

        public void InsertElementInHeap(int value)
        {

            if (Length < 0)
            {
                Console.WriteLine("Tree is empty");
            }
            else
            {
                //Insertion of value inside the Array happens at the last index of the  array
                Array[Length + 1] = value;
                Length++;
                HeapifyBottomToTop(Length);
                Console.WriteLine("Inserted " + value + " successfully in Heap !");
                levelOrder();
            }//end of method  
        }
        public void HeapifyBottomToTop(int index)
        {
            int parent = index / 2;
            // We are at root of the tree. Hence no more Heapifying is required.  
            if (index <= 1)
            {
                return;
            }
            // If Current value is smaller than its parent, then we need to swap  
            if (Array[index] < Array[parent])
            {
                int tmp = Array[index];
                Array[index] = Array[parent];
                Array[parent] = tmp;
            }
            HeapifyBottomToTop(parent);
        }//end of method  

        public void levelOrder()
        {
            Console.WriteLine("Printing all the elements of this Heap...");// Printing from 1 because 0th cell is dummy  
            for (int i = 1; i <= Length; i++)
            {
                Console.Write(Array[i] + " ");
            }
            Console.WriteLine("\n");
        }//end of method  
    }
}
