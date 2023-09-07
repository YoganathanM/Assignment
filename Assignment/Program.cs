while (true) {
   Console.Write ("Enter number : ");
   if (int.TryParse (Console.ReadLine (), out int num) && num > 0) {
      int sum = 0;
      do {
         while (num > 0) {
            sum = sum + num % 10;
            num /= 10;
         }
         num = sum;
         sum = 0;
      }
      while (num >= 10);
      Console.WriteLine ($"Digit root is {num}");
      break;
   } else
      Console.WriteLine ("Give a valid number");
}