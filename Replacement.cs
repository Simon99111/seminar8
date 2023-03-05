public class Replacement
{
    public static void Replace(int[,] table)
    {
        int mean = 0;
        int row = table.GetLength(0);
        int columns = table.GetLength(1);
        if (row == columns)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mean = table[i, j];
                    table[i, j] = table[j, i];
                    table[j, i] = mean;
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        else Console.WriteLine("Замена невозможна!");
    }

    public static void PrintArray(int[] array)
    {
        int count = array.Length;
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
}