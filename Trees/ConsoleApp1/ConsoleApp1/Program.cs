using ConsoleApp1;

BinaryTree binaryTree = new BinaryTree();
binaryTree.Root = new Node(1);
binaryTree.Root.Left = new Node(2);
binaryTree.Root.Right = new Node(3);
binaryTree.Root.Left.Left = new Node(4);
binaryTree.Root.Left.Right = new Node(5);
binaryTree.Root.Right.Left = new Node(6);
binaryTree.Root.Right.Right = new Node(7);

Console.WriteLine("Pre-order traversal:");
Console.WriteLine(string.Join(", ", binaryTree.PreOrderTraversal()));

Console.WriteLine("In-order traversal:");
Console.WriteLine(string.Join(", ", binaryTree.InOrderTraversal()));

Console.WriteLine("Post-order traversal:");
Console.WriteLine(string.Join(", ", binaryTree.PostOrderTraversal()));

BinarySearchTree binarySearchTree = new BinarySearchTree();
binarySearchTree.Add(100);
binarySearchTree.Add(50);
binarySearchTree.Add(150);
binarySearchTree.Add(25);
binarySearchTree.Add(75);
binarySearchTree.Add(125);
binarySearchTree.Add(175);

Console.WriteLine("Binary Search Tree contains 125: " + binarySearchTree.Contains(125));
Console.WriteLine("Binary Search Tree contains 90: " + binarySearchTree.Contains(90));