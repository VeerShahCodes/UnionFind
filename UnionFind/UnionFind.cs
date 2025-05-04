namespace UnionFind
{
    public class QuickFind<T>

    {
        private int[] sets;
        private Dictionary<T, int> map;

        public QuickFind(IEnumerable<T> items)
        {
            sets = new int[items.Count()];
            int i = 0;
            foreach(var item in items)
            {
                sets[i] = item
                i++;
            }
        }

        public int Find(T p) => sets[map[p]];
        public bool Union(T p, T q)
        {
            return false;
        }
        public bool AreConnected(T p, T q)
        {
            return false;
        }
    }

    public class QuickUnion<T>
    {
        private int[] parents;
        private Dictionary<T, int> map;

        public QuickUnion(IEnumerable<T> items)
        {

        }

        public int Find(T p)
        {
            return 0;
        }
        public bool Union(T p, T q)
        {
            return false;
        }
        public bool AreConnected(T p, T q)
        {
            return false;
        }
    }
}
