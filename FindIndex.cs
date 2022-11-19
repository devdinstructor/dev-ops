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
            foreach (var num in array)
            {
                if (num != number)
                {
                    continue;
                }

                index = num;
                break;
            }

            return index;
        }
    }
}