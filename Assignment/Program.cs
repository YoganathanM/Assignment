//Swap two Number from the given number list
Random rnd = new Random ();
int input = rnd.Next (5, 10);
Console.Write ("Input numbers : ");
List<int> numbers = new List<int> ();
for (int i = 0; i < input; i++) {
   int n = rnd.Next (1, 10);
   numbers.Add (n);
   Console.Write (n + " ");
}
Console.WriteLine ($"\nSwap two index values between 1 to {input}");
Console.Write ("Give index to be swapped : ");
int index1 = int.Parse (Console.ReadLine ()!);
Console.Write ("Give index to be swapped : ");
int index2 = int.Parse (Console.ReadLine ()!);
SwapIndices (index1, index2);
Console.Write ("Swapped output : ");
for (int j = 0; j < numbers.Count; j++) Console.Write (numbers[j] + " ");

void SwapIndices (int index1, int index2) => (numbers[index1 - 1], numbers[index2 - 1]) = (numbers[index2 - 1], numbers[index1 - 1]);