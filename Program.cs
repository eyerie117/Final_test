void ReleaseArray(string[] array)
{
    for (int i = 0; i < array.Length;)
    {
        if (array[i].Length > 3)
        {
            for (int j = i; j < array.Length - 1; j++)
            {
                array[j] = array[j + 1];
            }
            Array.Resize(ref array, array.Length - 1);
        }
        else if (array[i].Length <= 3)
            i++;
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

Console.Clear();
Console.WriteLine("Введите элементы массива через пробел: ");
string[] arr = Console.ReadLine().Split(new char[] { ' ' });
ReleaseArray(arr);