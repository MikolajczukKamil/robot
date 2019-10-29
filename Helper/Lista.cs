using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Helpers
{
    public class Lista<T> : IEnumerable<T>
    {
        class Node
        {
            public T Value;
            public Node Next;

            public Node(T val)
            {
                Value = val;
            }

            public void Add(T val)
            {
                if (Next == null) Next = new Node(val);
                else Next.Add(val);
            }

            public bool Remove(T val)
            {
                if (Next == null) return false;

                if(Next.Value.Equals(val))
                {
                    Next = Next.Next;
                    return true;
                }

                return Next.Remove(val);
            }

            public void RemoveAt(int i)
            {
                if (i == 0) Next = Next.Next;
                else Next.RemoveAt(i - 1);
            }
        }

        Node Root;
        int Count = 0;

        public int Length
        {
            get { return Count; }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (Node node = Root; node != null; node = node.Next)
                yield return node.Value;
        }

        public IEnumerator GetEnumerator()
        {
            for (Node node = Root; node != null; node = node.Next)
                yield return node.Value;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count) throw new System.IndexOutOfRangeException();

                for (Node node = Root;; node = node.Next)
                {
                    if (index == 0) return node.Value;

                    index--;
                }

                throw new System.IndexOutOfRangeException();
            }

            set
            {
                if (index < 0 || index >= Count) throw new System.IndexOutOfRangeException();

                for (Node node = Root;; node = node.Next)
                {
                    if (index == 0) {
                        node.Value = value;
                        break;
                    }

                    index--;
                }
            }
        }

        public void Add(T value)
        {
            if (Root == null) Root = new Node(value);
            else Root.Add(value);

            Count++;
        }

        public void Remove(T value)
        {
            if (Root == null) return;

            if (Root.Value.Equals(value))
            {
                Count--;
                Root = Root.Next;
            } else if(Root.Remove(value)) Count--;
        }

        public void RemoveAt(int i)
        {
            if (i < 0 || i >= Count) return;

            if (i == 0) Root = Root.Next;
            else Root.RemoveAt(i - 1);

            Count--;
        }

        public T First()
        {
            if (Count == 0) return default(T);

            return Root.Value;
        }

        public T Last()
        {
            if (Count == 0) return default(T);

            Node lastNode = Root;

            for (Node node = Root.Next; node != null; node = node.Next)
                lastNode = node;

            return lastNode.Value;
        }

        public bool Empty()
        {
            return Count == 0;
        }

        public bool HaveLength(int len)
        {
            return Count == len;
        }

        public bool LongerThen(int len)
        {
            return Count > len;
        }

        public bool ShorterThen(int len)
        {
            return Count < len;
        }

        public void Clear()
        {
            Root = null;
            Count = 0;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            bool first = true;

            builder.Append("[");

            foreach (T value in this)
            {
                if(!first) builder.Append(", ");

                builder.Append(value.ToString());

                first = false;
            }

            builder.Append("]");

            return builder.ToString();
        }
    }
}
