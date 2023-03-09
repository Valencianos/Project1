string[] array = {"hello", "2", ":-)", "world", "computer science"};
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        Console.Write($"{array[i]} ");
    }
}
