using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _1_1_StringHasAllUniqueChars
{
	class Program
	{
		/*
			Check if String has all unique characters
			the length has to be less than the number of characters for given encoding
			ASCII has 256 characters
			Unicode characters
			Does the case of characters matter : Assume it does not matter
			we need to keep track if we have encountered the character before
			1. Hashtable is one of the alternatives as it provides the index
			
			2. we can use the bool array with index being the integer value of the character
			   and check if the value at the chracter index is true 
				if true that means we have already seen the character so return fasle
				else
				set the index to true when we encounter the character 
		
			 */

		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			bool result = IsUniqueWithHashtable(input);
			bool result2 = IsUniqueArrayApproach(input);
			Console.WriteLine(result);
			Console.WriteLine(result2);
			Console.Read();
		}

		static bool IsUniqueWithHashtable(string input)
		{
			if (input == null) return true;
			if (input.Length > 256) // if its ASCII code
				return false;
			// if the case doesnot matter
			input = input.ToLower();
			Hashtable ht = new Hashtable();
			foreach (char c in input)
			{
				if (ht.Contains(c))
					return false;
				else
					ht.Add(c, 1);
			}
			return true;
		}

		static bool IsUniqueArrayApproach(string input)
		{
			if (input == null) return true;
			if (input.Length > 256) // character encoding can be used as input paramter also 
			{
				return false;
			}
			bool[] charTracking = new bool[256];
			input = input.ToLower();
			foreach(char c in input)
			{
				if (charTracking[c])
					return false;
				else
					charTracking[c] = true;
			}
			return true;
		}
	}
}
