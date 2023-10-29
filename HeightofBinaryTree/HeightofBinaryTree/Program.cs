
using HeightofBinaryTree;

BinaryTree tree = new BinaryTree();

tree.Root = new Node(1);
tree.Root.Left = new Node(2);
tree.Root.Right = new Node(3);
tree.Root.Left.Left = new Node(4);
tree.Root.Left.Right = new Node(5);

Console.WriteLine("Height of tree is "
                  + tree.MaxDepth(tree.Root));
