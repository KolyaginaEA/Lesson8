
{
    System.Random myRandom = new System.Random();
    System.Console.Write("m = ");
    int m = System.Convert.ToInt32(System.Console.ReadLine());
    System.Console.Write("n = ");
    int n = System.Convert.ToInt32(System.Console.ReadLine());

    int[,] array = new int[m, n];
    createarr(array);
    show(array);

    System.Console.WriteLine($"\nОтсортированный массив: ");
    BubbleSort(array);
    show(array);

    void BubbleSort(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(1) - 1; k++)
                {
                    if (arr[i, k] < arr[i, k + 1])
                    {
                        int temp = arr[i, k + 1];
                        arr[i, k + 1] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
            }
        }
    }

    void createarr(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = myRandom.Next(1, 100);
            }
        }
    }

    void show(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                System.Console.Write("{0} ", arr[i, j]);
            }
            System.Console.WriteLine();
        }
    }
    System.Console.ReadKey();
}