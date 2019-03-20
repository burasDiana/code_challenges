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
	
  
  static void Main() {  
    // keep this function call here
    
    Console.WriteLine(FirstFactorial(Console.ReadLine()));
  } 
}
