namespace DataStructuresAndAlgorithms.Basics
{
    public class BasicGraphDs
    {
        public int Size
        {
            get; set;
        }
        public LinkedList<int>[] Vertices
        {
            get; set;
        }
        public BasicGraphDs(int size)
        {
            Size = size;
            Vertices = new LinkedList<int>[Size];
            for (int i = 0; i < Vertices.Length; i++)
            {
                Vertices[i] = new LinkedList<int>();
            }
        }
        public void AddEdge(int vertixIndex, int edgeIndex)
        {
            Vertices[vertixIndex].AddLast(edgeIndex);
        }
        public void PrintAdjacencyList()
        {
            for (int i = 0; i < Vertices.Length; i++)
            {
                Console.Write($"[Node: {i} ");
                foreach (var edge in Vertices[i])
                {
                    Console.Write($" => {edge}");
                }
                Console.WriteLine($"]");
            }
        }

        public void CreateAdjacencyMartix()
        {
            int[,] adjacencyMatrix = new int[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                var parentNode = Vertices[i];
                for (int j = 0; j < Size; j++)
                {
                    if (parentNode.Any(v => v == j))
                    {
                        adjacencyMatrix[i, j] = 1;
                    }
                }
            }
            PrintAdjacencyMatrix(adjacencyMatrix);
        }

        private void PrintAdjacencyMatrix(int[,] matrix)
        {
            Console.WriteLine("-----------------");
            Console.Write("   |");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(" "+i);
            }
            Console.WriteLine();
            Console.WriteLine("-----------------");

                for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(i + "| [ ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var result = matrix[i, j] == 0 ? "." : "1";
                    Console.Write(result + " ");
                }
                Console.WriteLine(" ] ");
            }
        }
    }
}
