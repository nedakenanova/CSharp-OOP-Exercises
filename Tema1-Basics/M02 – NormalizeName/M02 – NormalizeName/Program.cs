 static string Normalize(string name)
{
    
    if(name==null || string.IsNullOrEmpty(name))
    {
        throw new ArgumentNullException("The name is null");
    }
    string[] words = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
for(int i = 0; i < words.Length; i++)
    {
        string word = words[i].ToLower();
        words[i] = char.ToUpper(word[0]) + word.Substring(1);
    }
return string.Join(" ", words);
}
 static void Main()
{
    string input1 = "  nEdA   kEnAnOvA  ";
    string input2 = "  ivan   ivanov  ";
    Console.WriteLine(Normalize(input1));
    Console.WriteLine(Normalize(input2));
}