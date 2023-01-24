string[] firstArray = new string[] { "hello", "world", "1234", "-2", ";-)", "Russia" };
string[] secondArray = new string[firstArray.Length];
SecondArrayAdd(firstArray, secondArray);
Print1DArr(firstArray);
Print1DArr(secondArray);

void SecondArrayAdd(string[] array, string[] newArray)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)

        {
            newArray[n] = array[i];
            n++;
        }
    }
}
void Print1DArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] != null)
            Console.Write(arr[i] + " ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}