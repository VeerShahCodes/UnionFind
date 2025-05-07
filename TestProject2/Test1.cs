namespace TestProject2
{
    using UnionFind;
    [TestClass]
    public sealed class Test1
    {
        QuickFind<int> qf = new QuickFind<int>(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        [TestMethod]
        public void TestFind()
        {
            Assert.IsTrue(qf.Find(2) == 1);
        }

        [TestMethod]
        public void TestUnion()
        {
            Assert.IsTrue(qf.Union(1, 2) == true);
        }
    }
}
