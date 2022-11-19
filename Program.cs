namespace devops
{

    public class Program
    {
        public void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 3, 4, 1, 5, 2, 4 };
            var firstIndex = new Array(array).FirstIndexOf(3);
            var lastindex = new Array(array).LastIndexOf(3);
        }
    }
}