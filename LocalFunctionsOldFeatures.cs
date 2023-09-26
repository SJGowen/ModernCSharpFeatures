namespace ModernCSharpFeatures;

public class LocalFunctionsOldFeatures
{
    public class Tree
    {
        public int Value { get; }
        private Tree Left { get; }
        private Tree Right { get; }

        public Tree(int value, Tree left = null, Tree right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public void PrintInPreOrder(string format)
        {
            PrintInPreOrder(this, format);
        }

        public void PrintInOrder(string format)
        {
            PrintInOrder(this, format);
        }

        public void PrintInPostOrder(string format)
        {
            PrintInPostOrder(this, format);
        }

        private void PrintInPreOrder(Tree tree, string format)
        {
            if (tree == null) return;

            PrintValue(tree, format);
            PrintInPreOrder(tree.Left, format);
            PrintInPreOrder(tree.Right, format);
        }

        private void PrintInOrder(Tree tree, string format)
        {
            if (tree == null) return;

            PrintInOrder(tree.Left, format);
            PrintValue(tree, format);
            PrintInOrder(tree.Right, format);
        }

        private void PrintInPostOrder(Tree tree, string format)
        {
            if (tree == null) return;

            PrintInPostOrder(tree.Left, format);
            PrintInPostOrder(tree.Right, format);
            PrintValue(tree, format);
        }

        private static void PrintValue(Tree tree, string format)
        {
            Console.Write($"{format} ", tree.Value);
        }
    }

    public LocalFunctionsOldFeatures()
    {
        Console.WriteLine(@"Tree:
         4
       /   \
      2     6
     / \   / \
    1   3 5   7
        ");

        var tree = new Tree(
            4,
            new Tree(2, new Tree(1), new Tree(3)),
            new Tree(6, new Tree(5), new Tree(7))
        );

        Console.WriteLine("Print in pre order: ");
        tree.PrintInPreOrder("<{0}>");
        Console.WriteLine("\n\nPrint in order: ");
        tree.PrintInOrder("{0}");
        Console.WriteLine("\n\nPrint in post order: ");
        tree.PrintInPostOrder("[{0}]");
        Console.WriteLine();
    }
}
