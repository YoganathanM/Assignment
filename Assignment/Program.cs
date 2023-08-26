while (true) {
   Console.Write ("Enter multiplication number :");
   if (int.TryParse (Console.ReadLine (), out int n) && n > 0) {
      for (int i = 1; i <= 12; i++)
         Console.WriteLine ($"{n} x {i,2} = {n * i}");
      break;
   } else
      Console.WriteLine ("Enter valid number");
}