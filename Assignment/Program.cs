bool abecedarianWord = true;
while (true) {
   Console.WriteLine ("Give number of words to check largest abecedarian word!");
   if (int.TryParse (Console.ReadLine (), out int n) && n > 0) {
      List<string> words = new List<string> ();
      List<string> output = new List<string> ();
      for (int i = 0; i < n; i++) {
         Console.Write ($"{i + 1} word : ");
         string word = Console.ReadLine ();
         if (string.IsNullOrWhiteSpace (word))
            continue;
         else
            words.Add (word);
      }
      for (int j = 0; j < words.Count; j++) {
         string str = words[j].ToLower ().Trim ();
         char[] ch = str.ToCharArray ();
         for (int i = 0; i < ch.Length - 1; i++) {
            if (ch[i] > ch[i + 1]) {
               abecedarianWord = false;
               break;
            } else
               abecedarianWord = true;
         }
         if (abecedarianWord)
            output.Add (words[j]);
      }
      if (output.Count == 0)
         Console.WriteLine ("None of the given word is abecedarian word!");
      else
         Console.WriteLine ($"The largest abecedarian word is {output.OrderByDescending (x => x.Length).First ()}");
      break;
   } else
      Console.WriteLine ("Give an valid number!");
}