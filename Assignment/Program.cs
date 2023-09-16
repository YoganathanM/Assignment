Console.Write ("Enter a string to reduce duplicate : ");
string str = Console.ReadLine () + " ";
int count;
do {
   count = 0;
   List<char> word = new List<char> ();
   for (int i = 0; i < str.Length - 1; i++) {
      if (str[i] == str[i + 1]) {
         i++;
         count++;
      } else
         word.Add (str[i]);
   }
   str = string.Concat (word) + " ";
} while (count > 0);
if (str.Length - 1 == 0)
   Console.WriteLine ("Empty string");
else
   Console.WriteLine ($"Reduced string is : {str}");