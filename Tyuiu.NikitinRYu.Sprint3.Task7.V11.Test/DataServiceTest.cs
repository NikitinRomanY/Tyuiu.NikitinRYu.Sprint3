using Tyuiu.NikitinRYu.Sprint3.Task7.V11.Lib;

namespace Tyuiu.NikitinRYu.Sprint3.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double[] wait = {
                20.36,
                15.42, 
                10.99,
                7.43,
                4.33,
                1.00,
                0,
                -8.87,
                -13.03,
                -16.53,
                -19.60
            };

            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
