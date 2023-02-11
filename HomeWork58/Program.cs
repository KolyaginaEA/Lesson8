 System.Random myRandom = new System.Random();
System.Console.Write("m1 = ");
int m1 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("n1 = ");
int n1 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("m2 = ");
int m2 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("n2 = ");
int n2 = System.Convert.ToInt32(System.Console.ReadLine());

if (n1 != m2)
{
    System.Console.Write("Невозможно перемножить матрицы");
    System.Environment.Exit(0);
}

int[,] array1 = new int[m1, n1];
int[,] array2 = new int[m2, n2];
int[,] array = new int[m1, n2];
System.Console.WriteLine("матрица 1:");
createarr(array1);
show(array1);
System.Console.WriteLine("матрица 2:");
createarr(array2);
show(array2);

P(array1, array2, array);
System.Console.WriteLine("\nПроизведение матриц: ");
show(array);

void P(int[,] arr1, int[,] arr2, int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int p = 0;
            for(int k = 0; k < arr2.GetLength(0); k++)
            {
                p += arr1[i, k] * arr2[k, j];
            }
            arr[i, j] = p;
        }
    }
}

void createarr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = myRandom.Next(1, 10);
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