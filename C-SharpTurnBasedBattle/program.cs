using BattleSystem;

Unit player = new Unit("KMG",20,50,100);
Unit enemy = new Unit("enemy",12,50,15);

Console.WriteLine("Welcome to Game go and fight to win");
while (player.GetCurrentHealth()>0 && enemy.GetCurrentHealth()>0) 
{
    Console.WriteLine("choose a For Attack or any key to get health");
    string option = Console.ReadLine().ToLower();
    if (option == "a")
    {
        player.Attack(enemy);
    }
    else
    {
        player.GetHeal(player);
    }
    Console.WriteLine("Enemy turn!");
    Random random = new Random();
    int rand = random.Next(0, 2);

    if (rand == 0)
        enemy.Attack(player);
    else
        enemy.GetHeal(enemy);

}
