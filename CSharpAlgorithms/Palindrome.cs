public class PalindromeNumber
{
    public static void Main()
    {
        Console.Write("Enter the number: ");
        string num = Console.ReadLine();

        string newNum = "";
        for (int i = num.Length - 1; i >= 0; i--)
        {
            newNum += num[i];
        }

        if (int.Parse(num) == int.Parse(newNum))
        {
            Console.WriteLine("{0} is a Palindrome", num);
        }
        
        Console.WriteLine("{0} is not a Palindrome", num);
        

    }
}