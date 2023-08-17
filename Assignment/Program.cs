for (; ; ) {
   Console.Write ("Enter word or sentence : ");
   string word = Console.ReadLine ().ToLower ().Replace (" ", "");
   if (word.Length == 0) {
      Console.WriteLine ("Empty please enter a text to check");
      continue;
   }
   var reversed = string.Join ("", word.Reverse ());
   if (word == reversed)
      Console.WriteLine ($"{word} is a palindrome");
   else
      Console.WriteLine ($"{word} is not a palindrome");
   break;
}