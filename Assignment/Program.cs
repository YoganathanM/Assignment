for (; ; ) {
   Console.Write ("Enter word or sentence : ");
   string word = Console.ReadLine ().ToLower ().Replace (" ", "");
   int wordCount = word.Length, count = 0;
   if (wordCount > 0) {
      for (int i = 0; i < word.Length; i++) {
         if (word[i] == word[word.Length - 1 - i])
            count++;
         else
            break;
      }
      if (count == wordCount) {
         Console.WriteLine ("palindrome");
         break;
      } else {
         Console.WriteLine ("Not a palindrome");
         break;
      }
   } else Console.WriteLine ("Empty please enter a text to check");
}