using System;
#region Exercise A02 - Guessing Game
Random rnd = new Random ();
int number = rnd.Next (1, 101);
Console.WriteLine ("Guess the number between 1 to 100");
for (; ; ) {
   Console.Write ("Enter guessed number :");
   string guessNumber = Console.ReadLine ();
   int output;
   bool check = int.TryParse (guessNumber, out output);
   if (check == true) {
      if (output == number) {
         Console.WriteLine ($"Guessed number is {number} ");
         break;
      } else if (output > number) Console.WriteLine ("Number is high");
      else Console.WriteLine ("Number is low");
   } else { Console.WriteLine ("Given Input is not an integer"); }
}
#endregion