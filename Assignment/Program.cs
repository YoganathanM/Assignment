namespace Assignment {
   internal class Program {
      static void Main (string[] args) {
         while(true) {
            Console.Write ("Enter total votes : ");
            string input = Console.ReadLine ()!.ToLower ().Replace (" ", "");
            if (input.Length > 0) {
               VotingContext (input);
               break;
            } else Console.WriteLine ("Input can't be empty");
         }
      }

      public static void VotingContext (string input) {
         Dictionary<char, int> vote = new ();
         for (int i = 0; i < input.Length; i++) {
            if (vote.ContainsKey (input[i])) vote[input[i]]++;
            else vote[input[i]] = 1;
         }
         var highestVote = vote.OrderByDescending (e => e.Value).First ();
         Console.WriteLine ($"Winner is {highestVote.Key}");
      }
   }
}