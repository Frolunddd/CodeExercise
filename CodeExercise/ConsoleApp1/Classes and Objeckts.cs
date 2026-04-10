// Classes and Objects 1

public class Test //Classes and Objects 1
{
    public Node getNode()
    {
        Node node;
        node = new Node();
        node.TAL = 1;
        return node;
    }
    public class Node
    {
        public int TAL;
    }
}



//	Classes And Objects 2
public class Test2
{
    public Node getList()
    {
        Node n;
        n = new Node();
        n.TAL = 1;
        n.NEXT = new Node();
        n.NEXT.TAL = 2;
        return n;
    }
    public class Node
    {
        public int TAL;
        public Node NEXT;
    }
}


