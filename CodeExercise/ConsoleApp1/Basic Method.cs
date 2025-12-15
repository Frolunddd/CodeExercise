// Basic Method 1


public int A(int a, int b, int c)
{
    return a + b + c;
}


public int B(int a, int b)
{
    int størsteTal = a;
    if (a < b)
    {
        størsteTal = b;
    }
    return størsteTal;
}

public char C(string a)
{
    return a[0];
}


// Basic Method 2
public bool D(string a)
{
    return a == a;
}
public char E(string a)
{
    return a[a.Length - 1];
}
public string F(string i)
{
    string output = "";
    if (i.Length == 1)
    {
        output = i;
    }
    if (i.Length > 1)
    {
        output = i[i.Length - 1] + "" + i[0];
    }
    return output;
}


// Basic Method 3
public char G(string a, int b)
{
    return a[b-1];
}
public string H(string a, string b)
{
    return a + b;
}
public bool I(string a, char b)
{
    return a[0] == b;
}

