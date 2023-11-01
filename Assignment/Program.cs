///<summary>Print diamond using asterisk</summary>
while (true) {
   Console.Write ("Give number of rows : ");
   if (int.TryParse (Console.ReadLine (), out int n) && (n > 0)) {
      int i, l, s, j;
      for (i = -n; i <= n; i++) {
         //condition to change negative value of i to positive using l variable to calculate space
         if (i < 0)
            l = -i;
         else
            l = i;
         for (s = 0; s < l; s++)
            Console.Write ("  ");
         for (j = 0; j < 2 * (n - l) + 1; j++)
            Console.Write ("* ");
         Console.WriteLine ();
      }
      break;
   } else
      Console.WriteLine ("Give an valid number");
}