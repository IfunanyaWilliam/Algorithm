
namespace CSharpAlgorithms
{
    public static class ArrayShifter
    {
        public static int[] ShiftRight(int[] input, int n)
        {
            // Handle edge cases
            if (input == null || input.Length == 0)
                return input;

            // Normalize n to avoid unnecessary full rotations
            n = n % input.Length;

            // If n is 0 after modulo, no shift needed
            if (n == 0)
                return (int[])input.Clone();

            int length = input.Length;
            int[] result = new int[length];

            // Copy elements to their new positions
            for (int i = 0; i < length; i++)
            {
                int newIndex = (i + n) % length;
                result[newIndex] = input[i];
            }

            return result;
        }


        // In-place version (modifies original array)
        public static void ShiftRightInPlace(int[] input, int n)
        {
            if (input == null || input.Length <= 1)
                return;

            n = n % input.Length;
            if (n == 0)
                return;

            // Reverse entire array
            Reverse(input, 0, input.Length - 1);

            // Reverse first n elements
            Reverse(input, 0, n - 1);

            // Reverse remaining elements
            Reverse(input, n, input.Length - 1);
        }

        private static void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
