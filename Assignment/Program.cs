Console.Write ("Enter text : ");
string word = Console.ReadLine ();
string str = word.ToLower ().Replace (" ", "");
bool isogram = Isogram (str);
if (isogram) Console.WriteLine ($"The given string {word} is an Isogram");
else Console.WriteLine ($"The given string {word} is not an isogram");
bool Isogram (string str) {
   char[] s = str.ToCharArray ();
   Array.Sort (s);
   for (int i = 0; i < s.Length - 1; i++) {
      if (s[i] == s[i + 1])
         return false;
   }
   return true;
}