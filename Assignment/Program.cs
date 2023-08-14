Console.Write ("Enter word or sentence : ");
string word = Console.ReadLine ().ToLower ().Replace (" ", "");
int wordCount = word.Length, count = 0;
for (int i = 0; i < word.Length; i++) {
   if (word[i] == word[word.Length - 1 - i])
      count++;
   else
      break;
}
if (count == wordCount)
   Console.WriteLine ("palindrome");
else
   Console.WriteLine ("Not a palindrome");