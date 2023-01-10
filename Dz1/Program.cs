int [,] array = new int [3,4] {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}  
};

for(int i = 0; i < array.GetLength(0); i++)

{
    for( int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
        
    }
    Console.WriteLine();
}

  for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = array.GetLength(1) - 1; j > 0; j--)
                {

                    for (int k = 0; k < j; k++)
                    {
                        if (array[i, k] < array[i, k + 1])
                        {
                            int temp = array[i, k];
                            array[i, k] = array[i, k + 1];
                            array[i, k + 1] = temp;
                        }
                    }
                }
                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]+ " " );
                }
                Console.WriteLine();
            }