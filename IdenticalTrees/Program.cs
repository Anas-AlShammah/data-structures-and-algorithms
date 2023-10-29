using IdenticalTrees;

BinaryTree tree = new BinaryTree();

tree.Root1 = new Node(1);
tree.Root1.Left = new Node(2);
tree.Root1.Right = new Node(3);
tree.Root1.Left.Left = new Node(4);
tree.Root1.Left.Right = new Node(5);

tree.Root2 = new Node(1);
tree.Root2.Left = new Node(2);
tree.Root2.Right = new Node(3);
tree.Root2.Left.Left = new Node(4);
tree.Root2.Left.Right = new Node(5);

// Function call
if (tree.IdenticalTree(tree.Root1, tree.Root2))
{
    Console.WriteLine("Both trees are identical");
}
else
{
    Console.WriteLine("Trees are not identical");
}