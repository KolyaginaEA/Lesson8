System.Random myRandom = new System.Random();
    System.Console.Write("m = ");
    int m = System.Convert.ToInt32(System.Console.ReadLine());
    System.Console.Write("n = ");
    int n = System.Convert.ToInt32(System.Console.ReadLine());

    int[,] array = new int[m, n];
    createarr(array);
    show(array);

    System.Console.Write("\nНаименьшая сумма в строке: {0}", search(array));

    double search(int[,] arr)
    {
        double[] Sum = new double[arr.GetLength(0)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            double sum = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j]; 
            }
            Sum[i] = sum;
        }
        double min = Sum[0];
        int k = 0;
        for (int i = 1; i < arr.GetLength(0); i++)
        {
            if (Sum[i] < min)
            {
                min = Sum[i];
                k = i;
            }
        }
        return k;
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
            
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                System.Console.Write("{0} ", arr[i, j]);
            }
            System.Console.WriteLine();
    }

System.Console.ReadKey();