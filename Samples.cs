// return the factorial of a given number

using System;

class MainClass {
  public static int FirstFactorial(int num) { 
    int result = 1;
    for (int i = 1 ; i<= num; i++){
        result = result * i;
    }
    return result;
            
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(FirstFactorial(Console.ReadLine()));
  } 
   
}
