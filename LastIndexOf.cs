namespace devops
{
    public partial class Array
    {
        private int[] array;
        public Array(int[] array)
        {
            this.array = array;
        }

        public int LastIndexOf(int number)
        {
            var indexOfNumber = -1;
            for (var index = this.array.Length - 1; index >= 0; index--)
            {
                if (this.array[index] != num)
                {
                    continue;
                }

                indexOfNumber = index;
                break;
            }

            return indexOfNumber;
        }
    }
}