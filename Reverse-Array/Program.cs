namespace Reverse_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[]arr = { 1, 2, 3, 5 };
            var ans=reverseArray(arr);
            foreach (int i in ans)
            {
                Console.WriteLine(i);
            }
          
            Console.ReadLine();
        }
        public static int[] reverseArray(int[] arr)
        {
            if (arr.Length < 1)
            {
                throw new Exception("no element in array to reverse");
            }
            int[] array = new int[arr.Length];
            int index = 0;
            foreach (int i in arr)
            {
                array[arr.Length-1-index++] = i;
            }
            
            return array;

        }
    }
}