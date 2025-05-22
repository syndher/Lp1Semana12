
namespace MyGenericClass
{

    public class Guarda3<T>
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
    }
}
