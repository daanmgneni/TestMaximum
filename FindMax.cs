


namespace GenreicDemo
{
    public class FindMax<T> where T : IComparable
    {
        private T[] values;

        public FindMax(params T[] values)
        {
            this.values = values;
        }

        public T MaximumNum()
        {
            T max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }
            return max;
        }

        
    }
}