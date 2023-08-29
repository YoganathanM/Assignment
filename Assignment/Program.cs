using System.Text;
for (; ; ) {
   Console.Write ("Enter a number : ");
   string input = Console.ReadLine ();
   if (int.TryParse (input, out int num)) {
      ToBinary (num);
      ToHexaDecimal (num);
      break;
   } else
      Console.WriteLine ("Give valid number");
}
static void ToBinary (int num) {
   var sb = new StringBuilder ();
   while (num > 0) {
      sb.Insert (0, num % 2);
      num /= 2;
   }
   Console.WriteLine ($"Binary : {sb}");
}

static void ToHexaDecimal (int num) {
   Dictionary<int, char> dict = new ()
   {
      { 10, 'A'}, {11, 'B' }, {12, 'C' }, {13, 'D' }, {14, 'E' }, {15, 'F' }
   };
   var sb = new StringBuilder ();
   while (num > 0) {
      var rem = num % 16;
      if (rem > 9 && dict.TryGetValue (rem, out var value))
         sb.Insert (0, value);
      else
         sb.Insert (0, rem);
      num /= 16;
   }
   Console.WriteLine ($"hexadecimal : {sb}");
}