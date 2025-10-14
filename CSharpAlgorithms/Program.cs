using CSharpAlgorithms;
using Newtonsoft.Json.Linq;
using System.Text.Json;

//Console.WriteLine("Hello, World!");

//int[] n = { 2, 4, 3, 9, 8, 18 };
//Console.WriteLine(SmallestPositiveInteger.Solution(n));



//Console.Write("Palindrome String Checker");
//Console.Write("Enter a word: ");
//string word = Console.ReadLine();

//bool check = PalindromeString.IsPalindrome(word);
//Console.Write("Palindrome Checker Response: ");
//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine($" Is \"{word}\" a Palindrome => {check}");
//Console.ForegroundColor = ConsoleColor.White;
//Console.WriteLine("\n  \n");



//string CheckEven(int n) => n % 2 == 0 ? "Even" : "Odd";

//Console.WriteLine(CheckEven(24));

//string str = "moOse";
//Console.WriteLine($"Is {str} an Isogram:  " + IsogramChecker.IsIsogram(str));

//var d = DateTime.Now;
//var st = DateTime.Now;
//Console.WriteLine(st.ToString("H:mm")); //Add .Substring(0,1)  to extract only the hour
//Console.WriteLine(d.AddHours(-1).ToString());

int[] nums = { 1, 2, 3, 4, 5, 6 };
int[] result = ArrayShifter.ShiftRight(nums, 2);

//Console.WriteLine("Enter a number: ");
//if(int.TryParse(Console.ReadLine(), out int n))
//{
//    LowerRightTriangle.Draw(n);
//}
//else
//{
//    Console.WriteLine("Your input is not a number");
//}

int answer = BinarySearch.Search(6, nums);
Console.WriteLine($"Search Result: {answer}");


