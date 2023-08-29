while (true) {
   Console.Write ("Enter number :");  
   if (int.TryParse (Console.ReadLine (), out int input) && input >= 0) {
      int rev = 0, num = input;
      while (num > 0) {
         rev = rev * 10 + num % 10;
         num /= 10;
      }
      Console.WriteLine ($"Reverse number is {rev}");
      if (input == rev)
         Console.WriteLine ($"{input} is a palindrome");
      else
         Console.WriteLine ($"{input} is not a palindrome");
      break;
   } else
      Console.WriteLine ("Give valid number");
}