using Tyuiu.OgorodnikDV.Sprint4.Task2.V24.Lib;

namespace Tyuiu.OgorodnikDV.Sprint4.Task2.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #24                                                              *");
            Console.WriteLine("* Выполнила: Огородник Дарья Вячеславовна | ИСПб-24-1                     *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 12;

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(4, 10);
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(numsArray[i] + "\t");
            }


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма не четных элементов массива равна:" + ds.Calculate(numsArray));



            Console.ReadKey();
        }
    }
}
