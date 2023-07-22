bool ValidateBrackets(string str)
{
    string str1 = "({[";
    string str2 = ")}]";
    List<int> list1 = new List<int>();
    List<int> list2 = new List<int>();
    foreach (char c in str)
    {
        if (str1.Contains(c))
        {
            list1.Add(str1.IndexOf(c));
        }else if (str2.Contains(c))
        {
            list2.Add(str2.IndexOf(c));
        }
    }
    if (list1.Count == list2.Count)
    {
        for (int i=0; i<list1.Count; i++)
        {
            if (list1[i] != list2[i])
            {
                return false;
            }
        }
        return true;
    }
    return false;
}
Console.WriteLine(ValidateBrackets("{}(){}"));
Console.WriteLine(ValidateBrackets("()[[Extra Characters]]"));
Console.WriteLine(ValidateBrackets("(){}[[]]"));
Console.WriteLine(ValidateBrackets("{}{Code}[Fellows](())"));
Console.WriteLine(ValidateBrackets("[({}]"));
Console.WriteLine(ValidateBrackets("(]("));
