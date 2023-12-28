namespace Assignment {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter total votes : ");
         string input = Console.ReadLine ()!.ToLower ().Replace (" ", "");
         VotingContext (input);
      }

      public static void VotingContext (string input) {
         Dictionary<char, int> vote = new ();
         for (int i = 0; i < input.Length; i++) {
            if (vote.ContainsKey (input[i]))
               vote[input[i]]++;
            else
               vote[input[i]] = 1;
         }
         var highestVote = vote.OrderByDescending (e => e.Value).First ();
         Console.WriteLine ($"Winner is {highestVote.Key}");
      }
   }
}