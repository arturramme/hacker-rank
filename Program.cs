var arr = new int[] { 1, 2, 3, 4, 3, 2, 1 };

int lonelyInteger = 0;

for (int i = 0; i < arr.Length; i++)
{
    for (int y = 0; y < arr.Length; y++)
    {
        if (arr[i] == arr[y] && i != y)
        {
            break;
        }

        lonelyInteger = arr[i];
    }
}

Console.WriteLine(lonelyInteger);