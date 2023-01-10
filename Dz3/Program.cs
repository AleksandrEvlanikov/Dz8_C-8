
int[,] firstMatrix = new int[4, 4]
{
{1, 4, 5, 8},
{21, 23, 8,1},
{11, 23, 15, 2},
{4, 5, 1, 18}
};

CreateArray(firstMatrix);
WriteArray(firstMatrix);

int[,] secomdMatrix = new int[4, 4]
{
{11, 24, 15, 18},
{2, 27, 8,5},
{11, 23, 15, 12},
{41, 15, 11, 18}
};
CreateArray(secomdMatrix);
WriteArray(secomdMatrix);

int[,] resultMatrix = new int[4,4];

MultiplyMatrix(firstMatrix, secomdMatrix, resultMatrix);
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secomdMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secomdMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}



void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,30);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}