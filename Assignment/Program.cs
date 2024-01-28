Console.WriteLine ("\x1B[4m" + "Calculate LCM AND GCD for given two numbers" + "\x1B[0m");
while (true) {
   Console.Write ("Enter first number : ");
   if (int.TryParse (Console.ReadLine ()!.Replace (" ", ""), out int n1) && (n1 > 0)) {
      while (true) {
         Console.Write ("Enter second number : ");
         if (int.TryParse (Console.ReadLine ()!.Replace (" ", ""), out int n2) && (n2 > 0)) {
            int x = n1, y = n2;
            while (y > 0) {
               int temp = y;
               y = x % y;
               x = temp;
            }
            int gcd = x;
            int lcm = (n1 * n2) / gcd;
            Console.WriteLine ($"The GCD of two number is {gcd}");
            Console.WriteLine ($"The LCM of two number is {lcm}");
            break;
         } Console.WriteLine ("Invalid number!");
      }
      break;
   } Console.WriteLine ("Invalid number!");
}