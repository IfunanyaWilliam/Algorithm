
namespace CSharpAlgorithms
{
    public static class DiagonalDifference
    {

        //Given a square matrix, calculate the absolute difference between the sums of its diagonals.
        //For example, the square matrix  is shown below:

            //1 2 3
            //4 5 6
            //9 8 9  

        public static int CalculateDiagonalDifference(List<List<int>> arr)
        {
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            int n = arr.Count; // Assuming arr is a square matrix

            for (int i = 0; i < n; i++)
            {
                primaryDiagonalSum += arr[i][i]; 
                secondaryDiagonalSum += arr[i][n - 1 - i];
            }

            // Return the absolute difference
            return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
        }
    }
}
