using Tyuiu.AnishchenkoVA.Sprint7.Project.V14.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint7.Project.V14.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(12, ds.GetTransport().Count());
        }
    }
}