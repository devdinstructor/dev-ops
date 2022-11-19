namespace devops
{
    public class Array
    {
        private int[] array;

        public Array(int[] array)
        {
            this.array = array;
        }

        public int IndexOf(int number)
        {
            var index = -1;
            var idx = -1;
            foreach (var num in array)
            {
                idx++;
                if (num == number)
                {
                    index = idx;
                    break;
                }
            }

            return index;
        }
    }
}