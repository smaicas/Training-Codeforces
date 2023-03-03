int numEntries = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numEntries; i++)
{
    string word = Console.ReadLine()!;
    if (word.Length > 10)
    {
        Console.Write(word.First());
        Console.Write(word[1..^1].Length);
        Console.Write(word.Last());
        Console.Write(Environment.NewLine);
    }
    else
    {
        Console.WriteLine(word);
    }
}
