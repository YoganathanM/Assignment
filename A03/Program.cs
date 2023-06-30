#region Exercise A03 -Spelling Bee
char[] letters = { 'U', 'X', 'A', 'L', 'T', 'N', 'E' };
var words = File.ReadAllLines ("C:/etc/words.txt");
Dictionary<string, int> SortDict = new Dictionary<string, int> ();
var pList = new List<string> ();
for (int i = 0; i < words.Length; i++) {
   if (words[i].Length >= 4) {
      string word = words[i];
      int length = word.Length;
      for (int j = 0; j < letters.Length; j++) {
         if (letters[j] == letters[0]) {
            for (int k = 0; k < length; k++) {
               char ch = word[k];
               if (ch == letters[j]) {
                  int count = 0;
                  for (int l = 0; l < letters.Length; l++) {
                     char res = letters[l];
                     for (int m = 0; m < length; m++) {
                        char test = word[m];
                        if (res == test) {
                           count++;
                        }
                     }
                     if (count == length) {
                        if (count == 4) {
                           count -= 3;
                        } else if (count >= 7) {
                           int pangramCount = 0;
                           for (int n = 0; n < letters.Length; n++) {
                              char res1 = letters[n];
                              for (int p = 0; p < length; p++) {
                                 char test1 = word[p];
                                 if (res1 == test1) {
                                    pangramCount++;
                                    break;
                                 }
                              }
                           }
                           if (pangramCount == letters.Length) {
                              count += 7;
                              SortDict.Add (word,count);
                              pList.Add (word);
                              break;
                           }
                        }
                        SortDict.Add (word, count);
                        break;
                     }  
                  }
                  break;
               }
            }
         }
      }
   }
}

var Score = SortDict.OrderByDescending (x => x.Value);
foreach(var test in Score) {
   if (pList.Contains (test.Key)) {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine ($"{test.Key} : {test.Value}");
      Console.ResetColor ();
      continue;
   }
   Console.WriteLine ($"{ test.Key} : { test.Value}");
}
#endregion