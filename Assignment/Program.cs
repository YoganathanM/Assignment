// Check strong password
var number = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var capitalLetter = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
var smallLetter = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
var symbol = new List<char> { ':', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' };
int count = 0;
Console.WriteLine ("Enter your password : ");
var passwordInput = Console.ReadLine ();
var password = passwordInput!.ToCharArray ();
if (password.Length >= 6) {
   count = count + 1;
   int capitalCount = 0;
   for (int i = 0; i < password.Length; i++) {
      for (int j = 0; j < capitalLetter.Count; j++) {
         if (password[i] == capitalLetter[j])
            break;
         else
            capitalCount = capitalCount + 1;
      }
   }
   if (password.Length * 26 != capitalCount) {
      count = count + 1;
      int numberCount = 0;
      for (int i = 0; i < password.Length; i++) {
         for (int j = 0; j < number.Count; j++) {
            if (password[i] - 48 == number[j]) break; else numberCount = numberCount + 1;
         }
      }
      if (password.Length * 10 != numberCount) {
         count = count + 1;
         int smallCount = 0;
         for (int i = 0; i < password.Length; i++) {
            for (int j = 0; j < smallLetter.Count; j++) {
               if (password[i] == smallLetter[j]) break; else smallCount = smallCount + 1;
            }
         }
         if (password.Length * 26 != smallCount) {
            count = count + 1;
            int symbolCount = 0;
            for (int i = 0; i < password.Length; i++) {
               for (int j = 0; j < symbol.Count; j++) {
                  if (password[i] == symbol[j]) break; else symbolCount = symbolCount + 1;
               }
            }
            if (password.Length * 13 != symbolCount) count = count + 1; else Console.WriteLine ("Password should contain at least one special character");
         } else Console.WriteLine ("Password should contain at least one lowercase English character");
      } else Console.WriteLine ("Password should contain at least one digit");
   } else Console.WriteLine ("Password should contain at least one uppercase English character" + "");
} else Console.WriteLine ("Password length should be atleast 6");
if (count == 5) Console.WriteLine ("Strong password");