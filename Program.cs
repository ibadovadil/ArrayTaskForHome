namespace ArrayHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] Array = { 1, 7, 16, 5, 9 };

            Console.Write("Original Array: [");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i]);
                if (i < Array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");


            int start = 0;
            int end = Array.Length - 1;
            while (start < end)
            {
                int temp = Array[start];
                Array[start] = Array[end];
                Array[end] = temp;

                start++;
                end--;
            }

            Console.Write("Reversed Array: [");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i]);
                if (i < Array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
    }
}