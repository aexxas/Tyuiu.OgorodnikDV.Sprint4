using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.OgorodnikDV.Sprint4.Task3.V27.Lib
{
    public class DataService : ISprint4Task3V27
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1; // кол-во строк
            int columns = array.Length / rows;   // кол-во столбцов 
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
