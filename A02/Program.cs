using System;
#region Exercise A02 - Guessing Game
int number = new Random ().Next (1, 101);
Console.WriteLine ("To exit type exit and press enter");
Console.WriteLine ("Guess the number between 1 to 100");
for (; ; ) {
   Console.Write ("Enter guessed number :");
   string guessNumber = Console.ReadLine ();
   bool check = int.TryParse (guessNumber, out int output);
   if (check) {
      if (output == number) {
         Console.WriteLine ($"Guessed number is {number} ");
         break;
      } else if (output > number) Console.WriteLine ("Number is high");
      else Console.WriteLine ("Number is low");
   } else if (guessNumber.ToString ().ToLower () == "exit")
      break;
   else Console.WriteLine ("Given input is not an valid number");
}
#endregion