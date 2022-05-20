using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Basics
{
    internal static class Arrays
    {
        public static void SingleDimensional()
        {
            int[] intArr = new int[10];
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = i;
            }
            printArray(intArr);
        }
        public static void MultiDimensional()
        {
            int[,] array = new int[4, 2];
            array[0, 0] = 1;
            array[0, 1] = 2;
            array[1, 0] = 3;
            array[1, 1] = 4;
            array[2, 0] = 5;
            array[2, 1] = 6;
            array[3, 0] = 7;
            array[3, 1] = 8;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.Rank; j++)
                {
                    Console.Write(array[i, j] + ((j == array.Rank - 1) ? "" : "-"));
                }
                Console.WriteLine();
            }
        }
        public static void MultiDimensional3D()
        {
            //3 D
            int[,,] array3D = new int[2, 2, 2];
            array3D[0, 0, 0] = 1;
            array3D[0, 0, 1] = 2;
            array3D[0, 1, 0] = 3;
            array3D[0, 1, 1] = 4;
            array3D[1, 0, 0] = 5;
            array3D[1, 0, 1] = 6;
            array3D[1, 1, 0] = 7;
            array3D[1, 1, 1] = 8;

            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.Write(array3D[i, j, k]);
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }

            }
        }
        public static void Jagged()
        {

        }
       public static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
        }
        public static void CopySkipIndex(int index)
        {
            int[] intArr = new int[10];
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = i;
            }
            int[] intArr2 = new int[9];
            // copy all except index 5
            for (int i = 0, j = 0; i < intArr.Length; i++, j++)
            {
                if (i == index)
                {
                    j--;
                }
                else
                    intArr2[j] = intArr[i];
            }
            printArray(intArr2);
        }
    }
}
