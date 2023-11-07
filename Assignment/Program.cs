// Check whether the given number is armstrong or not.
while (true) {
   Console.Write ("Enter number to check armstrong or not : ");
   string input = (Console.ReadLine ()?? " ").Trim ();
   int length = input.Length;
   if (int.TryParse (input, out int number)) {
      bool result = CheckArmstrong (number, length);
      if (result) Console.WriteLine ($"{number} is an armstrong number");
      else Console.WriteLine ($"{number} is Not an armstrong number");
      break;
   } else
      Console.WriteLine ("Give valid number");
}

static bool CheckArmstrong (int number, int length) {
   double sum = 0;
   int tempNumber = number;
   while (tempNumber > 0) {
      int rem = tempNumber % 10;
      tempNumber /= 10;
      sum += Math.Pow (rem, length);
   }
   if (number == sum) return true;
   return false;
}