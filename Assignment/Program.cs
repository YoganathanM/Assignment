static List<string> Perm (string word) {
   List<string> result = new List<string> ();
   var len = word.Length;
   if (len == 2)
      return new () { $"{word[0]}{word[1]}", $"{word[1]}{word[0]}" };
   else if (len == 3) {
      for (int i = 0; i < len; i++) {
         char c = word[i];
         string s = $"{word[(i + 1) % len]}{word[(i + 2) % len]}";
         List<string> temp = Perm (s);
         foreach (string str in temp) {
            result.Add (c + str);
         }
      }
   }
   return result;
}

Console.Write ("Enter word to permutate : ");
string input = Console.ReadLine ()!.ToLower().Replace(" ","");
if (input == "" || input.Length == 1) {
   Console.WriteLine ("Invalid input");
   return;
}
var output = Perm (input);
for (int i = 0; i < output.Count; i++) {
   Console.WriteLine ($"{i + 1} : {output[i]}");
}