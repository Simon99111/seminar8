
// 2. Заполнение случайными числами (1,10) (FillArray) - Юлия

int[,] FillArray(int m, int n) => new int[m, n];

void FillMatrix(int [,] mat, int min = 1, int max = 10)
{
  int row = mat.GetLength(0);
  int columns = mat.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
        mat[i, j] = new Random().Next(min, max);
        }
    }
}


//Задать двумерный массив
void SetArray(int x, int y)
{
    int[,] array = new int[x, y];
}

