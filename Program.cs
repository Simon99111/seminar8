// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//Задать двумерный массив
static void SetArraySize()
{
    int x, y;
    Console.WriteLine("Enter size of the rows: ");
    x = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Enter size of the colomns: ");
    y = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[x, y];
}