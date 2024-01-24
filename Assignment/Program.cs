namespace Assignment {
   internal class Program {
      static void Main (string[] args) {        
         var words = File.ReadAllLines ("C:/etc/input.txt");
         for (int i = 0; i < words.Length; i++) {
            Console.WriteLine (words[i]);
            //Splitting words based on :
            if (words[i].Contains (":")) {
               string[] gameId = words[i].Split (':');
               for (int a = 0; a < gameId.Length; a++) {
                  Console.WriteLine (gameId[a]);
                  //Splitting words based on ;
                  if (gameId[a].Contains (";")) {
                     string[] eachSet = gameId[a].Split (";");
                     for (int b = 0; b < eachSet.Length; b++) {
                        Console.WriteLine (eachSet[b]);
                        //Splitting words based on , 
                        if (eachSet[a].Contains (",")) {
                           string[] eachBall = eachSet[a].Split (",");
                           for (int c = 0; c < eachBall.Length; c++) {
                              Console.WriteLine (eachBall[c]);
                              //Splitting words based on empty space
                              if (eachBall[c].Contains (" ")) {
                                 string[] space = eachBall[c].Split (" ", StringSplitOptions.RemoveEmptyEntries);  
                                    int num=int.Parse (space[0]);
                                    string color = space[1];
                                    if (color == "green") {
                                       if (num <= 13) {
                                          continue;
                                       } else { break; }
                                    }
                                    if (color == "blue") {
                                       if (num <= 14) {
                                          continue;
                                       } else { break; }
                                    }
                                    if (color == "red") {
                                       if (num <= 12) {
                                          continue;
                                       } else { break; }
                                    }
                                 }
                              }
                           }
                        }
                        for (int j = 0; j < words[i].Length; j++) {
                           Console.WriteLine ();
                        }
                     }
                  }
               }
            }
         }
      }
   }