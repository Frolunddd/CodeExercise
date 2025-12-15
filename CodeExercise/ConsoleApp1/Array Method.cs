// Array Methods 1
using System.Xml;

public bool J(int[] a)
{
    return a.Length == 4;
}



// Array Methods 2
public int[] K(int[] a, int[] b)
{
   if (a.Length != 4 || b.Length != 4)
    {
        return new int[0];
    }

    int[] c = new int[8];
    for (int i = 0; i < 4; i++)
    {
        c[i] = a[i];
    }
    for (int i = 0; i < 4; i++)
    {
        c[i + 4] = b[i];
    }
    return c;
}


// Array Methods 3
public int[] L(int i)
{
    int[] output = new int[i];
    return output;
}
