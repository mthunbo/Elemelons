/// <summary>
/// Class responsible for the game loop and logic
/// </summary>
public class GameLoop
{
    public BaseMelon? Player { get; set; }
    public Brigand? Enemy { get; set;}

    public void Run(BaseMelon player)
    {
        Player = player;
        Console.Clear();
        var keepPlaying = 1;
        while(keepPlaying == 1)
        {
            Console.WriteLine("An enemy spots you and attacks");
            while (!Player.Unalived || !Enemy.Unalived)
            {
                double attack;
                Console.WriteLine(Player.Name);
                Console.WriteLine(Enemy.Name);

                // Player's turn to attack
                Console.WriteLine($"{Player.Name}'s Turn:");
                attack = Player.Attack();
                Enemy.Defend(attack);
                Console.WriteLine($"{Player.Name} did {attack} dmg on the enemy {Enemy.CurrentHealth}/{Enemy.MaxHealth}");

                if (Enemy.Unalived)
                {
                    Console.WriteLine($"{Enemy.Name} has been defeated!");
                    Player.GainExperience(Enemy.ExpValue);
                    Player.CurrentHealth = Player.MaxHealth;
                    Enemy.CurrentHealth = Enemy.MaxHealth;
                }

                // Enemy's turn to attack
                Console.WriteLine($"{Enemy.Name}'s Turn:");
                attack = Enemy.Attack();
                Player.Defend(attack);
                Console.WriteLine($"{Enemy.Name} did {attack} dmg on {Player.Name} {Player.CurrentHealth}/{Player.MaxHealth}");

                if (Player.Unalived)
                {
                    Console.WriteLine($"{Player.Name} has been defeated!");
                    Player.CurrentHealth = Player.MaxHealth;
                    Enemy.CurrentHealth = Enemy.MaxHealth;
                }

                // Pause for a moment between turns
                Console.WriteLine("\nPress any key for the next round...");
                Console.ReadKey();
            }
            Console.WriteLine("Press 1 to go again, presss 2 to exit;");
            keepPlaying = int.Parse(Console.ReadKey().KeyChar.ToString());
        }
    }
}