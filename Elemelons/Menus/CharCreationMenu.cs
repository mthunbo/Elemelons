
using System.Globalization;

/// <summary>
/// Class responsible for the character creation and the corresponding menu
/// </summary>
public class CharCreationMenu
{
    #region Fields
    private BaseMelon _baseMelon = new("");
    #endregion

    #region Constructor
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
                Console.WriteLine("\nPlease enter the name of your Character:");
                string name = Console.ReadLine();
                BaseMelon = CreateMelon(choice, name);
                choiceMade = true;            
            }
            else
            {
                Console.WriteLine("Invalid number try again");
            }

        }
    }
    #endregion

    #region Properties
    public BaseMelon BaseMelon{ 
        get{ return _baseMelon; } 
        set{ _baseMelon = value;} }
    #endregion

    #region Methods
    private static BaseMelon CreateMelon(int choice, string name)
    {
        switch (choice)
        {
            case 1:
                FireMelon fireMelon = new(name);
                return fireMelon;
            case 2:
                Watermelon waterMelon = new(name);
                return waterMelon;
            case 3:
                AirMelon airMelon = new(name);
                return airMelon;
            case 4:
                EarthMelon earthMelon = new(name);
                return earthMelon;
            default:
                return new BaseMelon(name);
        }
    }
    #endregion
}