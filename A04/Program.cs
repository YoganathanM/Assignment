#region Frequency table spelling bee
Dictionary<int, char> keyValuePairs = new Dictionary<int, char> ();
char[] letters = { 'U', 'X', 'A', 'L', 'T', 'N', 'E' };
char[] Alphabets = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
var words = File.ReadAllLines ("C:/etc/words.txt");
for (int i = 0; i < Alphabets.Length; i++) {
   char Alp = Alphabets[i];
   int count = 0;
   for (int j = 0; j < words.Length; j++) {
      string word = words[j];
      for (int k = 0; k < word.Length; k++) {
         char WD = word[k];
         if (Alp == WD) {
            count++;
         }
      }
   }
   keyValuePairs.Add (count, Alp);
}

var CountOrder = keyValuePairs.OrderByDescending (x => x.Key).Take (7);
foreach (var test in CountOrder) {
   Console.WriteLine ($"{test.Key} : {test.Value}");
}
#endregion