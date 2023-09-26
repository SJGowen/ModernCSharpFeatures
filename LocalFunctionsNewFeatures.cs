namespace ModernCSharpFeatures;

public class LocalFunctionsNewFeatures
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
            PrintInPreOrder(this);

            void PrintInPreOrder(Tree tree)
            {
                if (tree == null) return;

                PrintValue(tree, format);
                PrintInPreOrder(tree.Left);
                PrintInPreOrder(tree.Right);
            }
        }

        public void PrintInOrder(string format)
        {
            PrintInOrder(this);

            void PrintInOrder(Tree tree)
            {
                if (tree == null) return;

                PrintInOrder(tree.Left);
                PrintValue(tree, format);
                PrintInOrder(tree.Right);
            }
        }

        public void PrintInPostOrder(string format)
        {
            PrintInPostOrder(this);

            void PrintInPostOrder(Tree tree)
            {
                if (tree == null) return;

                PrintInPostOrder(tree.Left);
                PrintInPostOrder(tree.Right);
                PrintValue(tree, format);
            }
        }

        private static void PrintValue(Tree tree, string format)
        {
            Console.Write($"{format} ", tree.Value);
        }
    }


    public LocalFunctionsNewFeatures()
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
