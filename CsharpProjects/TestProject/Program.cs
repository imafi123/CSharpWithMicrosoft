Random dice = new Random();
int roll = dice.Next(1, 20);
Console.WriteLine(roll);

Random bigdice= new Random();
int roll1 = bigdice.Next();
int roll2 = bigdice.Next(101);
int roll3 = bigdice.Next(50, 101);

System.Console.WriteLine($"First roll: {roll1}");
System.Console.WriteLine($"First roll: {roll2}");
System.Console.WriteLine($"First roll: {roll3}");

