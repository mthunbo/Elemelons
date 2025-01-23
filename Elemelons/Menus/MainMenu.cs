

/// <summary>
/// Class responsible for showing the main menu
/// </summary>
public class MainMenu
{
    #region Fields
    private GameLoop _game = new();
    private CharCreationMenu? _char;
    #endregion

    #region Methods
    public void Show()
    {
        
        Console.WriteLine("------------- Welcome to Elemelons!!! -------------\n"
                        + "---- Please chose and option below to proceed: ----\n"
                        + "---- 1. Start game --------------------------------\n"
                        + "---- 2. Load saved character ----------------------\n"
                        + "---- 3. End game ----------------------------------\n");
        
        var choice = Console.ReadKey().KeyChar;

        switch (choice)
        {
            case '1':
                _char = new();
                _game.Run(_char.BaseMelon);
                break;
            case '2':
                //CharCreation.LoadOld();
                _char = new();
                _game.Run(_char.BaseMelon);
                break;
            case '3':
                break;
            default:
                break;
        }
    }
    #endregion
}