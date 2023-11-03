//Display the individual digits of a given number.
Console.Write ("Give decimal value to split : ");
string test = Console.ReadLine () ?? "";
if (double.TryParse (test, out double d) && d > 0)
   splitDigit (test);
else Console.WriteLine ("Enter valid input");
void splitDigit (string test) {
   var res = test.Length;
   char dot = '.';
   string integral = "";
   for (int i = 0; i <= res - 1; i++) {
      if (test[i] != dot) integral = integral + test[i];
      else break;
   }
   string fact = "";
   for (int k = integral.Length + 1; k < res; k++) fact = fact + test[k] + " ";
   if (fact.Length == 0) Console.WriteLine ("Invalid input");
   else {
      Console.Write ("Integral part : ");
      for (int j = 0; j < integral.Length; j++) Console.Write ($"{integral[j]} ");
      Console.Write ("\nFactorial part : ");
      Console.WriteLine (fact);
   }
}

