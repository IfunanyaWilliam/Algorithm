
namespace CSharpAlgorithms
{
    public static class LonelyInteger
    {
        //Given an array of integers, where all elements but one occur twice, find the unique element.
        //Example
        //static List<int> a = new List<int> { 1, 2, 3, 2, 1 };

        public static int FindLonelyInteger(List<int> a)
        {
            int unique = 0;

            foreach (var number in a)
            {
                unique ^= number; // XOR operation
            }

            return unique; // The result will be the unique number
        }
    }
}
