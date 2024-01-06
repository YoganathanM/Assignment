namespace Assignment {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("\x1B[4m" + "VOTING CONTEST" + "\x1B[0m");
         while (true) {
            Console.Write ("Enter total votes : ");
            string input = Console.ReadLine ()!.ToLower ().Replace (" ", "");
            if (input.Length > 0) {
               VotingContext (input);
               break;
            } else Console.WriteLine ("Input can't be empty");
         }
      }
      /// <summary>String provided by the user will be splitted into characters and which will be considered as vote</summary>
      /// <param name="input">Maximum count will be the winning contestant</param>
      public static void VotingContext (string input) {
         List<char> contestant = new ();
         List<int> totalVote = new ();
         while (input.Length > 0) {
            int inputLength = input.Length;
            int count = 0, i = 0;
            for (int j = i; j < inputLength; j++) if (input[i] == input[j]) count++;
            contestant.Add (input[i]);
            totalVote.Add (count);
            string refactoredInput = "";
            foreach (var a in input) if (a != input[i]) refactoredInput += a;
            input = refactoredInput;
         }
         int maximum = totalVote.Max ();
         for (int l = 0; l < totalVote.Count; l++) {
            if (totalVote[l] == maximum) {
               Console.WriteLine ($"Winner is {contestant[l]}");
               break;
            }
            break;
         }
      }
   }
}