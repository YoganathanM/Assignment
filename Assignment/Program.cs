for (; ; ) {
   Console.Write ("Enter a number : ");
   string decimalNumber = Console.ReadLine ();
   if (int.TryParse (decimalNumber, out int decimalNum)) {
      //Decimal to Binary
      int dec = decimalNum, i = 0;
      var l = new List<int> ();
      while (dec > 0) {
         int rem = dec % 2;
         l.Add (rem);
         dec /= 2;
      }
      Console.Write ("Binary : ");
      for (i = l.Count - 1; i >= 0; i--)
         Console.Write (l[i]);
      Console.WriteLine ();

      //Decimal to Hexadecimal
      int dec2 = decimalNum, k = 0;
      var hex = new List<string> ();
      Dictionary<int, char> dict = new ()
      {
   { 10, 'A'},
   {11, 'B' },
   {12, 'C' },
   {13, 'D' },
   {14, 'E' },
   {15, 'F' }
};
      var a = new List<int> ();
      while (dec2 > 0) {
         int rem = dec2 % 16;
         a.Add (rem);
         dec2 /= 16;
      }
      for (int j = 0; j < a.Count; j++) {
         var test = a[j];
         if (test > 9) {
            if (dict.ContainsKey (test))
               hex.Add (dict[test].ToString ());
         } else
            hex.Add (test.ToString ());
      }
      Console.Write ("Hexadecimal : ");
      for (k = hex.Count - 1; k >= 0; k--)
         Console.Write (hex[k]);
      break;
   } else Console.Write ("Enter a valid number");
}