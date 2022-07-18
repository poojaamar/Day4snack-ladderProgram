using Day4assignment;
Player play = new Player();

Console.WriteLine("Welcome to Snake & Ladder game problem.");

int player1 = play.GamePlay(1);
int player2 = play.GamePlay(2);
if (player1 < player2)
{
    Console.WriteLine("winner is player1.");
}
else if (player1 > player2)
{
    Console.WriteLine("winner is player2.");
}
else
{
    Console.WriteLine("Its a tie between Player 1 and 2.");
}
