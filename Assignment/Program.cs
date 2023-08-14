for (; ; ) {
   Console.Write ("Enter number to be checked :");
   if (int.TryParse (Console.ReadLine (), out int num)) {
      int count = 0;
      for (int i = 2; i < num; i++) {
         if (num % i != 0)
            count++;
         else {
            Console.Write ($"{num} is not a prime number");
            break;
         }
         if (count == num - 2)
            Console.Write ($"{num} is a prime number");
      }
      break;
   } else Console.WriteLine ("Enter valid number");
}