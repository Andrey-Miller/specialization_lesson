string[] ArrayModify(string[] array)
{
    int newArrLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) { newArrLength++; }
    }
    string[] newArray = new string[newArrLength];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}
string[] array = { "hello", "cat", "   ", "world", "^_^", "123", "-10", "----" };
string[] newArray = ArrayModify(array);
System.Console.WriteLine($"Исходный массив: [{string.Join(",", array)}]");
System.Console.WriteLine($"Новый массив: [{string.Join(",", newArray)}]");