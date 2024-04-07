string[] FillArray()
{
    Console.WriteLine("Введите данные через пробел и нажмите Enter: ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] workArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return workArray;
}

string PrintArray(string[] Array)
{
    string stringArray = "[";
    for (int i = 0; i < Array.Length; i++)
    {
        if (i == Array.Length - 1)
        {
            stringArray += $"\"{Array[i]}\"";
            break;
        }
        stringArray += ($"\"{Array[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}

int CountStringSymbols(string[] Array)
{
    int count = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] GenerateNewArray(string[] Array)
{
    int resultArrayLength = CountStringSymbols(Array);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in Array)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}

string[] Array = FillArray();
string[] resultArray = GenerateNewArray(Array);
string firstArray = PrintArray(Array);
string secondArray = PrintArray(resultArray);
Console.WriteLine(firstArray + " -> " + secondArray);