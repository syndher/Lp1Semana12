
using System.Collections;

namespace JustLikeACollection
{

    public class Guarda3<T> : IEnumerable<T>
    {
        private T placeholder0;
        private T placeholder1;
        private T placeholder2;
        public Guarda3()
        {
            placeholder0 = default;
            placeholder1 = default;
            placeholder2 = default;
        }
        public void Add(T item)
        {
            if (placeholder0 == null || placeholder0.Equals(default(T)))
            {
                placeholder0 = item;
            }
            else if (placeholder1 == null || placeholder1.Equals(default(T)))
            {
                placeholder1 = item;
            }
            else if (placeholder2 == null || placeholder2.Equals(default(T)))
            {
                placeholder2 = item;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return placeholder0;
            yield return placeholder1;
            yield return placeholder2;
        }

        public T GetItem(int i)
        {
            switch (i)
            {
                case 0: return placeholder0;
                case 1: return placeholder1;
                case 2: return placeholder2;
                default: throw new IndexOutOfRangeException();
            }
            
        }
        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0:
                    placeholder0 = item;
                    break;
                case 1:
                    placeholder1 = item;
                    break;
                case 2:
                    placeholder2 = item;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
