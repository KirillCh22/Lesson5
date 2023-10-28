//int[] array = new int[8];
int[,] array = GenerateArray2D();
PrintArray(array);
Console.WriteLine("_________________________________________________________");
Square(array);
PrintArray(array);
Console.WriteLine("_________________________________________________________");


int[,] GenerateArray2D()
{
    int[,] array = new int[6, 8];

    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}



void PrintArray(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}



void Square(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
             if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
}

