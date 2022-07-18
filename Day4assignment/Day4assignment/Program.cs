Console.WriteLine("Welcome to Snake & Ladder Game Program.");
int position = 0;
Random random = new Random();
int rolldie = random.Next(1, 7);
Console.WriteLine("Player 1 position is " + position);
Console.WriteLine("Roll Die value: " + rolldie);