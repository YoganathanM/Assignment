using System.Text;
using static System.Console;
while (true) {
   Write ("Enter a number : ");
   if (int.TryParse (ReadLine (), out int num) && num >= 0) {
      if (Convert (num, 2) == ToBinary (num) && Convert (num, 16) == ToHexa (num)) {
         WriteLine ($"Binary : {Convert (num, 2)}");
         WriteLine ($"Hexadecimal : {Convert (num, 16)}");
      } else
         WriteLine ("Output value differ");
      break;
   } else
      WriteLine ("Give valid number");
}
static string ToBinary (int num) {
   var sb = new StringBuilder ();
   while (num > 0) {
      sb.Insert (0, num % 2);
      num /= 2;
   }
   return sb.ToString ();
}
static string ToHexa (int num) {
   Dictionary<int, char> dict = new () {
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
   return sb.ToString ();
}
static string Convert (int num, int baseValue) => System.Convert.ToString (num, baseValue).ToUpper();

