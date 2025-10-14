
namespace CSharpAlgorithms
{
    public static class LowerRightTriangle
    {

        public static void Draw(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
