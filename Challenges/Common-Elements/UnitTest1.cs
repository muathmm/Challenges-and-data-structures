using Common_Elements;

namespace TestProject1
{
    public class UnitTest1
    {
       [Theory]
    [InlineData(new int[] { 1, 2, 3, 0 }, new int[] { 2, 3, 4, 9 }, new int[] { 2, 3 })]
    [InlineData(new int[] { 79, 8, 15 }, new int[] { 23, 79, 8 }, new int[] { 79, 8 })]
    public void TestCommonElements(int[] array1, int[] array2, int[] expected)
    {
            CommonElements C = new CommonElements();
        
            int[] result = C.CommonElement(array1, array2);

            Assert.Equal(expected, result);
    }
    }
}