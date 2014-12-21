using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTree
{
    class HashTable<T>
    {
        public delegate int HashFunc(T item);
        public delegate bool Match(T a,T b);
        public delegate bool UniqueMatch(T a, T b);
        private HashFunc hashFunc;
        private Match match;
        private UniqueMatch uniqueMatch;
        private List<T>[] table;
        private int num;

        public HashTable(int num,HashFunc hashFunc,Match match,UniqueMatch uniqueMatch)
        {
            this.hashFunc = hashFunc;
            this.match = match;
            this.uniqueMatch = uniqueMatch;
            this.table = new List<T>[num];
            this.num = num;
        }

        public void Add(T item)
        {
            if (table[Pos(item)] == null)
            {
                table[Pos(item)] = new List<T>();
            }
            table[Pos(item)].Add(item);
        }

        public List<T> Find(T item)
        {
            return table[Pos(item)].FindAll(delegate(T a)
            {
                return (match(a,item));
            });
        }

        public int Remove(T item)
        {
            return (table[Pos(item)].RemoveAll(delegate(T a)
            {
                return (uniqueMatch(a, item));
            }));
        }

        private int Pos(T item)
        {
            int pos = (hashFunc(item)) % num;
            return (Math.Abs(pos));
        }
    }
}
