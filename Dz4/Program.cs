
    int[,] array = new int[4,4];

    Random rnd = new Random();

    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            int newRandom;
            do
            {
                newRandom = rnd.Next(10, 99);
            }
            while (IsInArray(array, newRandom));
            array[i, j] = newRandom;
        }
    }

    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }


  static bool IsInArray(int[,] array, int newRandom)
  {
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (array[i, j] == newRandom)
            {
                return true;
            }
        }
    }
    return false;
  }

