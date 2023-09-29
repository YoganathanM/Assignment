internal class Program {
   private static void Main (string[] args) {
      List<int> armstrongList = new List<int> ();
      while (true) {
         if (int.TryParse (args[0], out int n) && n >= 0 && n <= 25) {
            var result = getArmstrongnumber (n);
            Console.WriteLine ($"{n} index armstrong number is {result}");
            break;
         } else
            Console.WriteLine ("Give valid number from 0 to 25");
         break;
      }
      int getArmstrongnumber (int n) {
         for (int i = 0; armstrongList.Count <= n; i++) {
            double armstrong = 0, sum = 0;
            int number, tempNumber, length;
            string input = i.ToString ();
            length = input.Length;
            number = Convert.ToInt32 (input);
            tempNumber = number;

            while (tempNumber > 0) {
               int rem = tempNumber % 10;
               tempNumber = tempNumber / 10;
               armstrong = Math.Pow (rem, length);
               sum = sum + armstrong;
            }
            if (number == sum)
               armstrongList.Add (number);
         }
         return armstrongList[n];
      }
   }
}