using Tyuiu.OgorodnikDV.Sprint4.Task7.V24.Lib;

namespace Tyuiu.OgorodnikDV.Sprint4.Task7.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Огородник Д.В | ИСПб-24-1";

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                 *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                   *");
            Console.WriteLine("* Задание #7                                                                *");
            Console.WriteLine("* Выполнила: Огородник Дарья Вячеславовна | ИСПб-24-1                       *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 651827384219648. Преобразуйте ее в      *");
            Console.WriteLine("* матрицу 5 на 3 и подсчитайте произведение четных чисел.                   *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            int rows = 5; // строк
            int columns = 3; // столбцов
            string str = "651827384219648";
            int[,] numbers = new int[rows, columns];
            int index = 0;

            Console.WriteLine("\nМассив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            int res = ds.Calculate(rows, columns, str);

            Console.WriteLine("Произведение четных чисел = " + res);
            Console.ReadKey();

        }
    }
}
