for (; ; ) {
   Console.Write ("Enter input number :");
   if (ulong.TryParse (Console.ReadLine (), out ulong n)) {
      ulong firstTerm = 0, secondTerm = 1;
      for (ulong i = 0; i < n; i++) {
         Console.WriteLine ($"f{i} : {firstTerm}");
         ulong thirdTerm = firstTerm + secondTerm;
         (firstTerm, secondTerm) = (secondTerm, thirdTerm);
      }
      break;
   } else Console.WriteLine ("Enter a valid number");
}