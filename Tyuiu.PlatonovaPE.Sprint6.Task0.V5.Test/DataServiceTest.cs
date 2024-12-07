using Tyuiu.PlatonovaPE.Sprint6.Task0.V5.Lib;
namespace Tyuiu.PlatonovaPE.Sprint6.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService(); 
            double res = ds.Calculate(5);
            double wait = -114.5;
            Assert.AreEqual(wait, res);
        }
    }
}