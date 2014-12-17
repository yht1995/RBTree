using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTree
{
    class HashTable<T>
    {
        private List<T>[] table;
        private delegate int HashFunc(T item);
        private HashFunc hashFunc;
        private int num;

        public HashTable(int num,HashFunc hashFunc)
        {
            this.hashFunc = hashFunc;
            this.table = new List<T>[num];
            this.num = num;
        }

        public void Insert(T item)
        {
            table[Pos(item)].Add(item);
        }

        public T Find(T item,Predicate<T> match)
        {
            return table[Pos(item)].Find(match);
        }

        public bool Delete(T item)
        {
            return(table[Pos(item)].Remove(item));
        }

        private int Pos(T item)
        {
            return (hashFunc(item) % num);
        }
    }
}
