

/// <summary>
/// Class responsible for the game loop and logic
/// </summary>
public class GameLoop
{
    public Backpack loot = new(100);
    public Backpack Backpack = new(100);
    public Inventory inventory= new("Player equipment");
    public BaseMelon Player { get; set; } = new();
    public Brigand Enemy { get; set;} = new();

    public void Run(BaseMelon player)
    {
        Player = player;
        Enemy.Loot = loot;
        Player.Backpack = Backpack;
        Player.Inventory = inventory;
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
    
    
    
    /*    
    #region Fields
    List<Item> items =
    [
        new Item("Book",4,1),
        new Item("Beer",2,4),
        new Item("Scissor",1,1),
    ];

    List<Equipment> equipments =
    [
        new Equipment("Dragon Helm",5, 22, "Helmet", 5, 5, 0, 0),
        new Equipment("Dragon Armor",15, 100, "Armor", 25, 25,0,0),
        new Equipment("Dragon Legs",10,50,"Legs",15,15,0,0),
        new Equipment("Dragons Greaves",8,35,"Greaves",10,10,0,0),
        new Equipment("Dragon Gloves",6, 30,"Gloves",8,8,0,0),
    ];
    //List<Item> items = Load json(Items.csv)
    //List<Equipment> equipment = load json(Equipment.csv)
    #endregion
        #region Constructor
        public GameLoop()
        {

        }
        #endregion

        #region Methods
        public void Run()
        {
            while (true)
            {

            }
        }
        public void End()
        {

        }
        #endregion 
        }
        
        */