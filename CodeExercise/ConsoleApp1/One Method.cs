// One Method 1


 
public string A(string a)
{
    return a + a;
}



// One Method 2
public string A(string a, string b)
{
    return a + b + a + b;
}



// One Method 3
public string A(string a, string b, string c)
{
    string længesteOrd = "";
    if (a.Length > længesteOrd.Length)
    {
        længesteOrd = a;
    }
    if (b.Length > længesteOrd.Length)
    {
        længesteOrd = b;
    }
    if (c.Length > længesteOrd.Length)
    {
        længesteOrd = c;
    }
    return længesteOrd;
}
