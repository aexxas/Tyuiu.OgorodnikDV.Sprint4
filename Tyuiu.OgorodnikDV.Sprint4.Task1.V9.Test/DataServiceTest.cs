using Tyuiu.OgorodnikDV.Sprint4.Task1.V9.Lib;

namespace Tyuiu.OgorodnikDV.Sprint4.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2, 7, 8, 1 };
            int wait = 73728;

            var rez = ds.Calculate(array);
            Assert.AreEqual(wait, rez);
        }
    }
}