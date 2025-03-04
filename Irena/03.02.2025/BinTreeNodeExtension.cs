using Unit4.CollectionsLib;
namespace _03._02._2025;

public static class BinTreeNodeExtension {
    public static int GetTreeSize<T>(this BinTreeNode<T>? node) {
        if (node is null) return 0;
        return 1 + node.GetLeft().GetTreeSize() + node.GetRight().GetTreeSize();
    }

    public static int GetTreeSum(this BinTreeNode<int>? node) {
        if (node is null) return 0;
        return node.GetInfo() + node.GetLeft().GetTreeSum() + node.GetRight().GetTreeSum();
    }

    public static int GetLeafCount<T>(this BinTreeNode<T>? node) {
        if (node is null) return 0;
        if (node.IsLeaf()) return 1;
        return node.GetLeft().GetLeafCount() + node.GetRight().GetLeafCount();
    }
    public static bool IsLeaf<T>(this BinTreeNode<T> node) {
        return node.GetRight() is null && node.GetLeft() is null;
    }

    public static bool IsLike<T, U>(this BinTreeNode<T>? node1, BinTreeNode<U>? node2) =>
        (node1, node2) switch {
            (null, null) => true,
            (null, _) or (_, null) => false,
            (BinTreeNode<T> one, BinTreeNode<U> other) =>
                IsLike(one.GetLeft(), other.GetLeft())
                && IsLike(one.GetRight(), other.GetRight())
        };

    public static bool IsIn<T>(this BinTreeNode<T>? node1, T target)
        where T : IEquatable<T> {
        if (node1 is null) return false;
        if (node1.GetInfo().Equals(target)) return true;
        return node1.GetLeft().IsIn(target) || node1.GetRight().IsIn(target);
    }
    public static BinTreeNode<int>? CreateBinTree(Func<int?> getValue, Action<BinTreeNode<int>> preLeft, Action<BinTreeNode<int>> preRight) {
        int? value = getValue();
        if (value is null) return null;
        var tree = new BinTreeNode<int>((int)value);
        preLeft(tree);
        tree.SetLeft(CreateBinTreeFromInput());
        preRight(tree);
        tree.SetRight(CreateBinTreeFromInput());
        return tree;
    }

    public static BinTreeNode<int>? CreateBinTree(Func<int?> getValue)
        => CreateBinTree(getValue, _b => { }, _b => { });

    public static BinTreeNode<int>? CreateBinTreeFromInput() =>
        CreateBinTree(() => {
            Console.WriteLine("Enter value");
            if (!int.TryParse(Console.ReadLine(), out int value) || value == -1)
                return null;
            return value;
        },
        _b => Console.WriteLine("left part of tree"),
        _b => Console.WriteLine("right part of tree"));
}
