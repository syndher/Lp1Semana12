
namespace MyGenericClass
{

    public class Guarda3<T>
    {
        private T placeholder1;
        private T placeholder2;
        private T placeholder3;
        public Guarda3()
        {
            placeholder1 = default(T);
            placeholder2 = default(T);
            placeholder3 = default(T);
        }
    }
}
