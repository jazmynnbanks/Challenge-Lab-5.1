Dictionary<int, int> countNumbers = new Dictionary<int, int>();
int[] myArray = { 4, 1, 2, 2, 1 };   

foreach (int num in myArray)

{
    if (countNumbers.ContainsKey(num))
    {
        countNumbers[num]++;
    }
    else
    {
        countNumbers[num] = 1;

    }
}

foreach (var pair in countNumbers)
{
    if (pair.Value == 1)
    {
        Console.Write(pair.Key);
    }
}
