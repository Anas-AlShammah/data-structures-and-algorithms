using ConsoleApp1;

BinaryTree tree = new BinaryTree();
tree.root = new Node(2);
tree.root.Left = new Node(7);
tree.root.Right = new Node(5);
tree.root.Left.Right = new Node(6);
tree.root.Left.Right.Left = new Node(1);
tree.root.Left.Right.Right = new Node(11);
tree.root.Right.Right = new Node(9);
tree.root.Right.Right.Left = new Node(4);

// Function call
Console.WriteLine("Maximum element is "
                  + tree.FindMax(tree.root));
