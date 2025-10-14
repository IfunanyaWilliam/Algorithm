
namespace CSharpAlgorithms
{
    public static class BinarySearch
    {
        public static int Search(int target, int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int left = 0;
            int right = numbers.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (numbers[mid] == target) return numbers[mid];

                else if(numbers[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}
