using System.Collections.Generic;
using System.Linq;
using System;

// Forma que eu fiz
//public class Kata
//{
//    public static string SpinWords(string sentence)
//    {
//        string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

//        foreach (string word in words)
//        {
//            if (word.Length >= 5)
//            {
//                var arrayChars = word.ToCharArray();

//                Array.Reverse(arrayChars);

//                string reversedword = new string(arrayChars);

//                sentence = sentence.Replace(word, reversedword);
//            }
//        }

//        return sentence;
//    }
//}

// -------------------------------------------------------------------------------------------------------------------------

//forma que poderia ser feito:

//public class Kata
//{
//    public static string SpinWords(string sentence)
//    {
//        return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string minhaString = "Esta é uma frase de exemplo PARALELO aeiou aei";

//        string wordReversed = Kata.SpinWords(minhaString);

//        Console.WriteLine($"Número de palavras: {wordReversed}");
//    }
//}