namespace Common_Elements
{
    public class Program
    {
        static void Main(string[] args)

        {
            CommonElements C=new CommonElements();
            int []arr1 = { 79, 8, 15 };
            int[] arr2 = { 23, 79, 8 };
            int[] result = C.CommonElement(arr1,arr2);
            foreach (var item in result)
            {
                Console.Write(item+",");
            }
        }
        
    }
   

   
}
