
using System.Globalization;

/// <summary>
/// Class responsible for the character creation and the corresponding menu
/// </summary>
public class CharCreationMenu
{
    public CharCreationMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Character Creation Menu!");
        Console.WriteLine("Please choose the type of character you want to create:");
        Console.WriteLine("1. FireMElon");
        Console.WriteLine("2. WaterMelon");
        Console.WriteLine("3. AirMelon");
        Console.WriteLine("4. EarthMelon");

        bool choiceMade = false;
        while (!choiceMade)
        {
            
            Console.Write("Enter the number of your choice: ");
            int choice = int.Parse(Console.ReadKey().KeyChar.ToString());
            if (!(choice < 1 && choice > 4))
            {
                Console.WriteLine("Please enter the name of your Character:");
                BaseMelon.Name = Console.ReadLine();
                BaseMelon = CreateMelon(choice, BaseMelon);
                choiceMade = true;            
            }
            Console.WriteLine("Invalid number try again");

        }
    }

    public BaseMelon BaseMelon{ get; set; } = new();

    public BaseMelon CreateMelon(int choice, BaseMelon baseMelon)
    {
        BaseMelon = baseMelon;
        switch (choice)
        {
            case 1:
                FireMelon fireMelon= new(baseMelon.Name, baseMelon.AttackPower, baseMelon.NativeDefense, baseMelon.Experience, baseMelon.Level, baseMelon.CurrentHealth, baseMelon.MaxHealth, baseMelon.Unalived, baseMelon.IsAttackable, baseMelon.Backpack, baseMelon.Inventory);
                return fireMelon;
            case 2:
                Watermelon waterMelon = new(baseMelon.Name, baseMelon.AttackPower, baseMelon.NativeDefense, baseMelon.Experience, baseMelon.Level, baseMelon.CurrentHealth, baseMelon.MaxHealth, baseMelon.Unalived, baseMelon.IsAttackable, baseMelon.Backpack, baseMelon.Inventory);
                return waterMelon;
            case 3:
                AirMelon airMelon = new(baseMelon.Name, baseMelon.AttackPower, baseMelon.NativeDefense, baseMelon.Experience, baseMelon.Level, baseMelon.CurrentHealth, baseMelon.MaxHealth, baseMelon.Unalived, baseMelon.IsAttackable, baseMelon.Backpack, baseMelon.Inventory);
                return airMelon;
            case 4:
                EarthMelon earthMelon = new(baseMelon.Name, baseMelon.AttackPower, baseMelon.NativeDefense, baseMelon.Experience, baseMelon.Level, baseMelon.CurrentHealth, baseMelon.MaxHealth, baseMelon.Unalived, baseMelon.IsAttackable, baseMelon.Backpack, baseMelon.Inventory);
                return earthMelon;
            default:
                return new BaseMelon();
        }
    }
}