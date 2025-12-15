using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

// Loop Array Method 1
public class TestArray1
{
    public int numberOfLetters(String s, char b)
    {
        int c = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == b)
            {
                c++;
            }
        }
        return c;
    }
}

// Loop Array Method 2
public class TestArray2
{
    public int sumOfAllNumbers(int[] numbers)
    {
        int output = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            output = output + numbers[i];
        }
        return output;
    }
}

// Loop Array 3
public class TestArray3
{
    public String theLongestWord(string[] list)
    {
        string longestWord = "";
        for (int i = 0; i < list.Length; i++)
        {
            if (longestWord.Length < list[i].Length)
            {
                longestWord = list[i];
            }
            
        }
        return longestWord;
    }
}

// Loop Array 4
public class TestArray4
{
    public String mostLettersInWord(String[] list, char c)
    {
        string wordInArray = "";
        int charUsed = 0;
        
        for (int i = 0; i < list.Length; i++)
        {
            int count = 0;
            for (int a = 0; a < list[i].Length; a++)
            {
                if (list[i][a] == c)
                {
                    count++;
                }
            }
            if (count > charUsed)
            {
                charUsed = count;
                wordInArray = list[i];
            }
        }
        return wordInArray;
    }
}

// Loop Array 5
public class TestArray5
{
    public Boolean theSameInBoth(int[] a, int[] b)
    {
        bool sameInBoth = true;
        for (int i = 0; i < b.Length; i++)
        {
            if (a[i] != b[i])
            {
                sameInBoth = false;
            }
        }
        return sameInBoth;
    }
}

// Loop Array 6
public class TestArray6
{
    public int[] sumOfBothArrays(int[] a, int[] b)
    {
        int[] c = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
             c[i] = a[i] + b[i];
        }
        return c;
    }
}

// Loop Array 7
public class TestArray7
{
    public int[] lengthOffTheWords(String[] List)
    {
        int[] Length = new int[List.Length];
        for (int i = 0; i < List.Length; i++)
        {
            Length[i] = List[i].Length;
        }
        return Length;
    }
}

// Loop Array 8
public class TestArray8
{
    public int theSumOfLength(String[] list)
    {
        int sum = 0;
        for (int i = 0; i < list.Length; i++)
        {
            sum = sum + list[i].Length;
        }
        return sum;
    }
}

// Loop Array 9
public class TestArray9
{
    public bool mirrorArray(int[] arr)
    {
        bool mirror = true;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != arr[arr.Length -1 - i])
            {
                mirror = false;
            }
        }
        return mirror;
    }
}