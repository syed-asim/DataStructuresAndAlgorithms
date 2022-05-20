using DataStructuresAndAlgorithms.Basics;
using DataStructuresAndAlgorithms.Questions;

//ValidateSyntaxUsingStack.Run("[[{{()()}}{}]]");
//StackDs.Run();
//HasbTableDs.Run();
//QueueDs.Run();
// Basic Graph
//BasicGraphDs graph = new BasicGraphDs(5);
////A
//graph.AddEdge(0, 1);
//graph.AddEdge(0, 2);
////B
//graph.AddEdge(1, 3);
////C
//graph.AddEdge(2, 2);
////D
//graph.AddEdge(3, 2);
////E
//graph.AddEdge(4, 0);
//graph.AddEdge(4, 2);

//graph.PrintAdjacencyList();
//graph.CreateAdjacencyMartix();


// Generic Graph
GraphDs<string> graphGen = new GraphDs<string>();

graphGen.AddNode("A");
graphGen.AddNode("B");
graphGen.AddNode("C");
graphGen.AddNode("D");
graphGen.AddNode("E");
graphGen.AddNode("F");
graphGen.AddNode("G");
graphGen.AddNode("H");

//A
graphGen.AddEdge("A", "B");
graphGen.AddEdge("A", "C");
//B
graphGen.AddEdge("B", "D");
//C
//graphGen.AddEdge("C", "C");
//D
graphGen.AddEdge("D", "C");
graphGen.AddEdge("D", "F");
graphGen.AddEdge("D", "G");
//E
graphGen.AddEdge("E", "A");
graphGen.AddEdge("E", "C");
//G
graphGen.AddEdge("G", "H");

graphGen.PrintGraph();
Console.WriteLine("BFS traversal of Graph...");
graphGen.BFSTraversal("E");

Console.WriteLine("DFS traversal of Graph...");
graphGen.DFSTraversal("E");
graphGen.DFSTraversal("D");


// Binary Tree
////BinaryTree binaryTree = new BinaryTree(
////    new BinaryNode("A",
////        new BinaryNode("B", new BinaryNode("C"), new BinaryNode("D")),
////        new BinaryNode("E", new BinaryNode("F", new BinaryNode("G"), null), new BinaryNode("H", new BinaryNode("i"), new BinaryNode("J")))
////    ));
////Console.WriteLine("Breadth First Traversal");
////binaryTree.BFSTraversal();
////binaryTree.BFSSearch("F");
////Console.WriteLine("Depth First Traversal");
////binaryTree.DFSTraversal(binaryTree.Root);

// Fraud Detection solution
//FraudDetection.Run();
