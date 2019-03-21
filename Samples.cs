using System;
using System.Linq;

class MainClass {
	
  // return the factorial of a given number
  public static int FirstFactorial(int num) { 
    int result = 1;
    for (int i = 1 ; i<= num; i++){
        result = result * i;
    }
    return result;
  }
 
  // return the reverse of a string	
  public static string FirstReverse(string str) { 
	string res = "";
	for (int i = str.Length - 1; i>= 0; i--){
		res = res + str[i];
	}
    return res;
  }

  // return the longest word in a string
  public static string LongestWord(string sen) { 
    string[] words = sen.Split(' ');
    return words.OrderByDescending( s => RemovePunctuation(s).Length ).First();;
  }
 
// helper method for removing non alphabet characters
 public static string RemovePunctuation(string word)
  {
      StringBuilder wordWithoutPunctuation = new StringBuilder();
      
      foreach (char c in word)
      {
          if (!char.IsPunctuation(c))
          {
              wordWithoutPunctuation.Append(c);
          }
      }
      return wordWithoutPunctuation.ToString();
  }
  
	/*Have the function LetterChanges(str) take the str parameter being passed and modify it 
	using the following algorithm. Replace every letter in the string with the letter following it in the alphabet
	(ie. c becomes d, z becomes a). Then capitalize every vowel in this new string (a, e, i, o, u) and 
	finally return this modified string. Use the Parameter Testing feature in the box below to test 
	your code with different arguments.*/

	public static string LetterChanges(string input)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] vowels = "aeiou".ToCharArray();
            char[] inputCopy = input.ToCharArray();

            for(int i = 0; i<= input.Length-1; i++)
            {
                if (alphabet.Contains(input[i])) // ignore if it is not a letter 
                {
                    int index = Array.IndexOf(alphabet, input[i]);
                    if (index == alphabet.Length - 1) //is it the last letter? a.k.a 'z'
                    {
                        inputCopy[index] = alphabet[0]; // set it to 'a'
                    }
                    else
                    {
                        inputCopy[i] = alphabet[index + 1]; // replace with next letter
                    }

                    if (vowels.Contains(inputCopy[i]))
                    {
                        inputCopy[i] = Char.ToUpper(inputCopy[i]); // replace with uppercase letter
                    }
                }
            }
            return new string(inputCopy);
        }

  static void Main() {  
    // keep this function call here
    
    Console.WriteLine(FirstFactorial(Console.ReadLine()));
  } 
}
