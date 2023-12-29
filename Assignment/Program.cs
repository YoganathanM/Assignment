// Swap two Number from the given number list
Random rnd = new();
int randomNumber = rnd.Next (5, 10);
Console.Write ("Input numbers : ");
List<int> numbers = new ();
for (int i = 0; i < randomNumber; i++) {
   int n = rnd.Next (1, 10);
   numbers.Add (n);
   Console.Write (n + " ");
}
///<summary>validating two input number given by user</summary>
Console.WriteLine ($"\nSwap two index values between 0 to {randomNumber}");
GetIndex1:
Console.Write ("Give index to be swapped : ");
if(!(int.TryParse(Console.ReadLine(), out int index1) && index1>=0)) {
   Console.WriteLine ("Invalid index value");
   goto GetIndex1;
}
GetIndex2:
Console.Write ("Give index to be swapped : ");
if (!(int.TryParse (Console.ReadLine (), out int index2) && index2 >= 0)) {
   Console.WriteLine ("Invalid index value");
   goto GetIndex2;
}
SwapByIndex (index1, index2);
Console.Write ("Swapped output : ");
for (int j = 0; j < numbers.Count; j++) Console.Write (numbers[j] + " ");

///<summary>Interchanges the values in the index positions of an list</summary>
void SwapByIndex (int index1, int index2) => (numbers[index1], numbers[index2]) = (numbers[index2], numbers[index1]);