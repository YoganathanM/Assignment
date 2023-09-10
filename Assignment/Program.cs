while (true) {
   int i, s, j, l = 1;
   Console.Write ("Give number of rows : ");
   if (int.TryParse (Console.ReadLine (), out int n) && (n > 0)) {
      for (i = 0; i < n; i++) {
         for (s = 0; s < n - i - 1; s++)
            Console.Write ("  ");
         for (j = 0; j < i + 1; j++) {
            if (j == 0 || i == 0)
               l = 1;
            else
               l = l * (i - j + 1) / j;
            Console.Write ($"   {l}");
         }
         Console.WriteLine ();
      }
      break;
   } else
      Console.WriteLine ("Give an valid number");
}