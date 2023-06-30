#region Exercise A02 - Guessing Game
Random rnd = new Random ();
int number = rnd.Next (101);
int i;
Console.WriteLine ("Guess the number between 1 to 100");
for (i = 0; i < 7; i++) {
   Console.Write ("Enter guessed number :");
   int userNum = Convert.ToInt32 (Console.ReadLine ());
   if (userNum == number) {
      Console.WriteLine ($"Guessed number is {number} ");
      break;
   } else if (userNum > number) {
      Console.WriteLine ("Number is high");
   } else {
      Console.WriteLine ("number is low");
   }
}
if (i == 7) { Console.WriteLine ("Computer guess number is:" + number); };
#endregion

