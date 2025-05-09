namespace TestProject2
{
    using UnionFind;
    [TestClass]
    public sealed class Test1
    {
        QuickFind<int> qf = new QuickFind<int>(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        QuickFind<int> qu = new QuickFind<int>(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

        [TestMethod]
        public void QFTestFind()
        {
            Assert.IsTrue(qf.Find(2) == 1);
        }

        [TestMethod]
        public void QFTestUnion()
        {
            Assert.IsTrue(qf.Union(1, 2) == true);
        }

        [TestMethod]
        public void QFTestUnionAlreadyConnected()
        {
            Assert.IsTrue(qf.AreConnected(6,7) == false);
        }

        [TestMethod]
        public void QUTestFind()
        {
            Assert.IsTrue(qu.Find(2) == 1);
        }

        [TestMethod]
        public void QUTestUnion()
        {
            Assert.IsTrue(qu.Union(1, 2) == true);
        }

        [TestMethod]
        public void QUTestUnionAlreadyConnected()
        {
            Assert.IsTrue(qu.AreConnected(6, 7) == false);
        }
    }
}
