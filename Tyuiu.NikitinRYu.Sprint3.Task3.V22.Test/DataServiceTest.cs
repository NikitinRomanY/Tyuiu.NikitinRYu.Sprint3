using Tyuiu.NikitinRYu.Sprint3.Task3.V22.Lib;

namespace Tyuiu.NikitinRYu.Sprint3.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();
            string value = "tbtbbb dsfbg bbg";
            char item = 'b';
            int wait = 3;
            int res = ds.GetMaxCharCount(value, item);
            Assert.AreEqual(wait, res);
        }
    }
}
