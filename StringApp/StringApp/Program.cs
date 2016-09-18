using System;

namespace StringApp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			//reverseWords("Hello worlds!");
			String srcTest = "Hello my friends";
			String toRemove = "my";

			String result = RemoveChar.removeChar (srcTest, toRemove);
			Console.WriteLine (result);
		}


		private static void reverseWords(String str)
		{
			String[] words = str.Split (null);
			String[] reversedWords = reverseWordsArray (words);

			printStr (reversedWords);
		}

		public static string[] reverseWordsArray(String[] words)
		{
			int i, j = words.Length;
			for (i = 0, j = words.Length  - 1; i < j; i++, j--) {

				String temp = words [i];
				words [i] = words [j];
				words [j] = temp;

			}
			return words;
		}

		private static void printStr(String[] words)
		{
			for (int i = 0; i < words.Length; i++) {
				Console.WriteLine (words [i]);
			}
		}

	}
}
