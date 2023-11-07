// Performs swapping of two variables values.
Console.Write ("Enter A value : ");
int a =int.Parse(Console.ReadLine ()??"");
Console.Write ("Enter B value : ");
int b = int.Parse (Console.ReadLine () ?? "");
swap(a, b);
void swap (int a, int b) {
   int temp = 0;
   temp = a;
   a = b;
   b = temp;
   Console.WriteLine ($"A value is {a}");
   Console.WriteLine ($"B value is {b}");
}
