namespace Find_Duplicate
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int[] array = { 5, 10, 16, 20, 10, 16 };
            int[] result = FindDuplicates(array);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] FindDuplicates(int[] array)
        {
            int maxValue = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

          
            int[] frequency = new int[maxValue + 1];

         
            for (int i = 0; i < array.Length; i++)
            {
                frequency[array[i]]++;
            }
            foreach (var item in frequency)
            {
                Console.Write(item);
            }



            int[] tempDuplicates = new int[array.Length];
            int duplicatesIndex = 0;
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] > 1)
                {
                    tempDuplicates[duplicatesIndex++] = i;
                }
            }

        
            int[] result = new int[duplicatesIndex];
            for (int i = 0; i < duplicatesIndex; i++)
            {
                result[i] = tempDuplicates[i];
            }

            return result;
       
        }
    }
}
