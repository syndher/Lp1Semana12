
namespace TheyCameBefore
{

    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T after)
        where T : struct, IComparable<T>
        {
            foreach (T item in items)
            {
                if (item.CompareTo(after) < 0)
                {
                    yield return item;
                }
            }
        }
    }
}
