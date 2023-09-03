string[] FilterShortStrings(string [] arr, int length)
{
    string [] newArr = new string[arr.Length];
    int index = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Trim().Length <= length)
        {
            newArr[index] = arr[i];
            index++;
        }   
    }
    return newArr;
}