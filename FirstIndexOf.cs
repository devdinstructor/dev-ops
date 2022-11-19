namespace devops
{
    public partial class Array
    {
        private int[] array;
        public Array(int[] array)
        {
            this.array = array;
        }

        public int FirstIndexOf(int number)
        {
            var indexOfNumber = -1;
            for (var index = 0; index < this.array.Length; index++)
            {
                if (this.array[index] == num)
                {
                    indexOfNumber = index;
                    break;
                }
            }

            return indexOfNumber;
        }
    }
}