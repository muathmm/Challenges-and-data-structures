using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Elements
{
    public class CommonElements
    {
        public  int[] CommonElement(int[] array1, int[] array2)
        {


            int maxLength = array1.Length < array2.Length ? array1.Length : array2.Length;
            int[] tempCommonElements = new int[maxLength];
            int commonCount = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        tempCommonElements[commonCount] = array1[i];
                        commonCount++;
                        break;
                    }
                }
            }

            int[] commonElements = new int[commonCount];
            for (int i = 0; i < commonCount; i++)
            {
                commonElements[i] = tempCommonElements[i];
            }

            return commonElements;



        }
    }
}
