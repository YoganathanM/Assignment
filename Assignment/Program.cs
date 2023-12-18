   Console.Write ("Give number to find factorial : ");
   if (int.TryParse (Console.ReadLine (), out int input) && input > 0 && input <=25) {
      PrintFactorial (input);
   } else Console.WriteLine ("Given input is an invalid number!");

///<summary>Print factorial for the given number</summary>
void PrintFactorial (int input) {
   int fact = 1;
   for (int i = 1; i <= input; i++) fact *= i;
   Console.WriteLine ($"Factorial of {input}! : {fact}");
}