// See https://aka.ms/new-console-template for more information
using CSharpAlgorithms;

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



string CheckEven(int n) => n % 2 == 0 ? "Even" : "Odd";

Console.WriteLine(CheckEven(24));

string str = "moOse";
Console.WriteLine($"Is {str} an Isogram:  " + IsogramChecker.IsIsogram(str));

//var d = DateTime.Now;
//var st = DateTime.Now;
//Console.WriteLine(st.ToString("H:mm")); //Add .Substring(0,1)  to extract only the hour
//Console.WriteLine(d.AddHours(-1).ToString());