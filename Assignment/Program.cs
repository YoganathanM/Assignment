Console.Write ("Enter a value : ");
int a =int.Parse(Console.ReadLine ());
Console.Write ("Enter b value : ");
int b = int.Parse (Console.ReadLine ());
swap (a, b);

void swap (int a, int b) {
   (a, b) = (b, a);
   Console.Write ($"a value is : {a}\n");
   Console.Write ($"b value is : {b}");
}