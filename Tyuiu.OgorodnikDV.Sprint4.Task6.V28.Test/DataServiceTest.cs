using Tyuiu.OgorodnikDV.Sprint4.Task6.V28.Lib;

namespace Tyuiu.OgorodnikDV.Sprint4.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var water = new string[] { "����", "�����", "������", "�����", "����", "����" };

            string[] wait = { "�����", "������", "�����" };
            string[] res = ds.Calculate(water);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}