Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

System.Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (total >= 15){
    Console.WriteLine("You win!");
}

if (total < 15){
    Console.WriteLine("You Lose.");
}

if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3)){
    Console.WriteLine("You rolled a double! You get 2 bonus points!");

    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3)){
    System.Console.WriteLine("You rolled triples! You get 6 bonus points!");

    total total += 6;
}