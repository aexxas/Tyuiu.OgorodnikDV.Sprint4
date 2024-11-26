using Tyuiu.OgorodnikDV.Sprint4.Task6.V28.Lib;

namespace Tyuiu.OgorodnikDV.Sprint4.Task6.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Огородник Д.В | ИСПб-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема : Класс Array                                                           *");
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #28                                                                  *");
            Console.WriteLine("* Выполнила: Огородник Дарья Вячеславовна | ИСПб-24-1                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

           var water = new string[] { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };

            for (int i = 0; i <= water.Length - 1; i++)
            {
                Console.WriteLine(water[i]);
            }
            string[] res = ds.Calculate(water);
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");

            for (int j = 0; j <= res.Length - 1; j++)
            {
                Console.WriteLine(res[j]);
            }
        }
    }
}
