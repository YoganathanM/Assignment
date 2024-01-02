namespace Training;
class Spark {
   public static void Main () {
      Console.WriteLine ("\x1B[4m" + "Chocolate Wrapper Problem" + "\x1B[0m");
      int moneyGiven = 0, chocolatePrice = 0, wrapperValue = 0;
      GetInput (ref moneyGiven, ref chocolatePrice, ref wrapperValue);
      Console.WriteLine ();
      GetResult (moneyGiven, chocolatePrice, wrapperValue);
   }

   /// <summary>Gets input from user</summary>
   /// <param name="moneyGiven"></param>
   /// <param name="chocolatePrice"></param>
   /// <param name="wrapperValue"></param>
   /// <returns>Returns number of chocolates, remaining wrapper, remaining money </returns>
   public static (int, int, int) GetInput (ref int moneyGiven, ref int chocolatePrice, ref int wrapperValue) {
GetMoney: Console.Write ("Enter money : ");
      if (!(int.TryParse (Console.ReadLine (), out moneyGiven) && moneyGiven > 0)) {
         Console.WriteLine ("Give valid money");
         goto GetMoney;
      }
GetPrice: Console.Write ("Enter chocolate price : ");
      if (!(int.TryParse (Console.ReadLine (), out chocolatePrice) && chocolatePrice > 0)) {
         Console.WriteLine ("Give valid chocolate price");
         goto GetPrice;
      }
GetWrapper: Console.Write ("Enter wrapper value : ");
      if (!(int.TryParse (Console.ReadLine (), out wrapperValue) && wrapperValue > 1)) {
         Console.WriteLine ("Give wrapper value greater than 1");
         goto GetWrapper;
      }
      return (moneyGiven, chocolatePrice, wrapperValue);
   }

   /// <summary>Prints results of number of chocolate, wrappers, remaining</summary>
   /// <param name="moneyGiven"></param>
   /// <param name="chocolatePrice"></param>
   /// <param name="wrapperValue"></param>
   public static void GetResult (int moneyGiven, int chocolatePrice, int wrapperValue) {
      var (extraWrapper, remaining) = (0, 0);
      int chocolate = moneyGiven / chocolatePrice;
      remaining += moneyGiven % chocolatePrice;
      extraWrapper += chocolate;
      while (extraWrapper >= wrapperValue) {
         int extraChocolate = extraWrapper / wrapperValue;
         extraWrapper %= wrapperValue;
         chocolate += extraChocolate;
         extraWrapper += extraChocolate;
      }
      Console.WriteLine ($"Total choclate : {chocolate}");
      Console.WriteLine ($"Remaining wrapperValue : {extraWrapper}");
      Console.WriteLine ($"Remaining moneyGiven : {remaining}");
   }
}