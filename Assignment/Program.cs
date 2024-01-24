namespace Assignment {
   internal class Program {
      static void Main (string[] args) {
         var words = File.ReadAllLines ("C:/etc/input.txt");
         for (int i = 0; i < words.Length; i++) {
            //Splitting words based on :
            int countEntry = 0;
            int count = 0;
            if (words[i].Contains (":")) {
               string[] gameId = words[i].Split (':');
               for (int a = 0; a < gameId.Length; a++) {
                  //Splitting words based on ;
                  if (gameId[a].Contains (";")) {
                     string[] eachSet = gameId[a].Split (";");
                     for (int b = 0; b < eachSet.Length; b++) {
                        //Splitting words based on , 
                        if (eachSet[b].Contains (",")) {
                           string[] eachBall = eachSet[b].Split (",");
                           for (int c = 0; c < eachBall.Length; c++) {
                              //Splitting words based on empty space
                              if (eachBall[c].Contains (" ")) {
                                 string[] space = eachBall[c].Split (" ", StringSplitOptions.RemoveEmptyEntries);
                                 int num = int.Parse (space[0]);
                                 string color = space[1];
                                 countEntry++;
                                 if (color == "green")
                                    if (num <= 13) count++; else break;
                                 if (color == "blue")
                                    if (num <= 14) count++; else break;
                                 if (color == "red")
                                    if (num <= 12) count++; else break;
                              }
                           }
                        }
                     }
                     if (count == countEntry)
                        Console.WriteLine (gameId[0]);
                  }
               }
            }
         }
      }
   }
}
