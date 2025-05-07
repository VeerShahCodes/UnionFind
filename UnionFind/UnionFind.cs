namespace UnionFind
{
    public class QuickFind<T>

    {
        private int[] sets;
        private Dictionary<T, int> map;

        public QuickFind(IEnumerable<T> items)
        {
            
            sets = new int[items.Count()]; //initalizes the array to the number of items
            int i = 0;
            map = new Dictionary<T, int>();
            foreach (var item in items) //loops through all items
            {
                map[item] = i;//maps item to its index cus u cant put T in int array
                sets[i] = i;   
                i++;
            }
        }

        public int Find(T p) => sets[map[p]];
        public bool Union(T p, T q)
        {
            bool worked = false;
            if (sets[map[p]] == sets[map[q]]) return false; //if they are already connected
            for (int i = 0; i < sets.Length; i++)
            {
                if (sets[i] == sets[map[p]])
                {
                    sets[i] = sets[map[q]];
                    worked = true;
                }
            }
            return worked;
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
