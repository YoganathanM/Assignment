Console.Write ("Enter text : ");
string word = Console.ReadLine () ?? "";
string str = word.ToLower ().Replace (" ", "");
if (str.Length > 0) {
   bool isogram = Isogram (str);
   if (isogram) Console.WriteLine ($"The given string {word} is an Isogram");
   else Console.WriteLine ($"The given string {word} is not an isogram");
} else Console.WriteLine ("Please give an valid input!");

///<summary>Checks whether the given string is isogram or not.</summary>
bool Isogram (string str) {
   char[] s = str.ToCharArray ();
   Array.Sort (s);
   for (int i = 0; i < s.Length - 1; i++) {
      if (s[i] == s[i + 1]) return false;
   }
   return true;
}