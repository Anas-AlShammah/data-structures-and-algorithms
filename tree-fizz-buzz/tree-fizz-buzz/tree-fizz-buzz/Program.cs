using tree_fizz_buzz;

KaryNode root = new KaryNode(15);
root.Children.Add(new KaryNode(3));
root.Children.Add(new KaryNode(5));
root.Children.Add(new KaryNode(10));
root.Children[2].Children.Add(new KaryNode(20));

FizzBuzzTree fizzBuzzTree = new FizzBuzzTree();
KaryNode newTreeRoot = fizzBuzzTree.FizzBuzz(root);

PrintTree(newTreeRoot);

Console.ReadLine();
static void PrintTree(KaryNode node, string indent = "")
{
    if (node != null)
    {
        Console.WriteLine(indent + node.Value);
        foreach (var child in node.Children)
        {
            PrintTree(child, indent + "  ");
        }
    }
}