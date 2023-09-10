bool abecedarianWord = true;
Console.Write ("Enter a string to validate : ");
string word = Console.ReadLine ();
string str = word.ToLower ().Replace (" ", "");
char[] s = str.ToCharArray ();
for (int i = 0; i < s.Length - 1; i++) {
   if (s[i] > s[i + 1]) {
      abecedarianWord = false;
      break;
   }
}
if (abecedarianWord)
   Console.WriteLine ($"Given word {word} is an abecedarian word");
else
   Console.WriteLine ($"Given word {word} is not an abecedarian word");