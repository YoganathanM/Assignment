// Find factorial for the given number.
while (true) {
   Console.Write ("Give number to find factorial : ");
   if (int.TryParse (Console.ReadLine (), out int input) && (input > 0)) {
      Factorial (input);
      break;
   } else Console.WriteLine ("Given input is an invalid number!");
}
void Factorial (int input) {
   int fact = 1;
   for (int i = 1; i <= input; i++) {
      fact = fact * i;
   }
   Console.WriteLine ($"Factorial of {input}! : {fact}");
}