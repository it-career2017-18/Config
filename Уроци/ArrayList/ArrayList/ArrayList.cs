using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class ArrayList<T>
    {
        private const int InitialCapacity = 2;
        private T[] items;

        public ArrayList()
        {
            this.items = new T[InitialCapacity];
        }

        public int Count
        {
            get;
            private set;
        }

        public T this[int index]{
            get {
                if (index >= Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: "+index);
                }
                return this.items[index];
            }
            set {
                if (index >= Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }
                this.items[index] = value;
            }
        }

        public void Add(T item){
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        private void Resize()
        {
            T[] copy = new T[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        public T RemoveAt(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }

            T element = this.items[index];
            this.items[index] = default(T);
            this.Shift(index);
            this.Count--;

            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            return element;
        }

        private void Shift(int index)
        {
            for (int i = index; i < Count; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }

        private void Shrink()
        {
            T[] copy = new T[this.items.Length / 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }
    }
}
