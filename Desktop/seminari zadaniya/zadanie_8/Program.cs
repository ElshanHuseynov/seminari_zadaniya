// Задача 54

class Program
{    
    static void Main()
    {
        int[,] array = 
        {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int[] tempArray = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                tempArray[j] = array[i, j];
            }

            Array.Sort(tempArray);
            Array.Reverse(tempArray);

            for (int j = 0; j < cols; j++)
            {
                array[i, j] = tempArray[j];
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}