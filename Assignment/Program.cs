Console.Write ("Enter number to be checked :");
int num;
while (!int.TryParse (Console.ReadLine (), out num))
   Console.WriteLine ("Enter valid number");
bool isPrime = true;
for (int i = 2; i < num; i++) {
   if (num % i == 0) {
      isPrime = false;
      Console.Write ($"{num} is not a prime number");
      break;
   }
}
if (isPrime) Console.Write ($"{num} is a prime number");