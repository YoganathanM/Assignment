#region Exercise A03 -Spelling Bee
using System.Collections.Generic;
using System.Linq;
using System;

char[] letters = { 'U', 'X', 'A', 'L', 'T', 'N', 'E' };
var words = File.ReadAllLines ("C:/etc/words.txt");
Dictionary<string, int> wordDict = new ();
List<string> pangramList = new ();
words = words.Where (x => x.Length >= 4).ToArray ();
foreach (var word in words) {
   if (word.Contains (letters[0])) {
      var result = word.Length;
      int count = 0;
      foreach (var i in word) {
         if (letters.Any (x => x == i))
            count++;
      }
      if (count == result) {
         if (count == 4)
            wordDict.Add (word, count - 3);
         else if (count > 4 && count < 7)
            wordDict.Add (word, count);
         if (count >= 7) {
            int pangramCount = 0;
            foreach (var i in letters) {
               if (word.Contains (i))
                  pangramCount++;
            }
            if (pangramCount == letters.Length) {
               wordDict.Add (word, count + 7);
               pangramList.Add (word);
            } else
               wordDict.Add (word, count);
         }
      }
   }
}
var score = wordDict.OrderByDescending (x => x.Value);
foreach (var i in score) {
   if (pangramList.Contains (i.Key)) {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine ($"{i.Key} : {i.Value}");
      Console.ResetColor ();
      continue;
   }
   Console.WriteLine ($"{i.Key} : {i.Value}");
}
#endregion