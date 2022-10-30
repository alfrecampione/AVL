namespace DLL;

public class Tree<T>
{
    public T[] Keys { get; }
    public Tree<T>[] Children { get; }

    public Tree(int order)
    {
        if (order > 1)
        {
            Keys = new T[order - 1];
            Children = new Tree<T>[order];
        }
        else
        {
            Keys = new T[0];
            Children = new Tree<T>[0];
        }
    }
}

public class BinaryTree<T> : Tree<T>
{
    public T Value
    {
        get { return Keys[0]; }
        set { Keys[0] = value; }
    }

    public BinaryTree<T>? Left
    {
        get { return Children[0] as BinaryTree<T>; }
        set { Children[0] = value!; }
    }

    public BinaryTree<T>? Right
    {
        get { return Children[1] as BinaryTree<T>; }
        set { Children[1] = value!; }
    }

    public BinaryTree(T value) : base(2)
    {
        Value = value;
    }
}