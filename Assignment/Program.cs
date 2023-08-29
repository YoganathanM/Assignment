while (true) {
   Console.Write ("Enter number :");
   int reverse = 0;
   if (int.TryParse (Console.ReadLine (), out int originalNumber) && originalNumber >= 0) {
      int number = originalNumber;
      while (number > 0) {
         int remainder = number % 10;
         reverse = reverse * 10 + remainder;
         number = number / 10;
      }
      Console.WriteLine ($"Reverse number is {reverse}");
      if (originalNumber == reverse)
         Console.WriteLine ($"{originalNumber} is a palindrome");
      else
         Console.WriteLine ($"{originalNumber} is not a palindrome");
      break;
   } else
      Console.WriteLine ("Give valid number");
}