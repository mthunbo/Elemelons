
/// <summary>
/// Chest class that will contain items as a reward for the player
/// </summary>
public class Chest :Container
{

    public Chest() : base("Chest")
    {
        _maxValue = MaxValue;
    }

    #region Fields
    private int _maxValue = 100;
    #endregion

    #region Properties
    /// <summary>
    /// Max combined value of all items in the chest
    /// </summary>
    public int MaxValue { 
        get{ return _maxValue; } 
        set
        {
            if(value < 0)
            {
                _maxValue = 100;
            }
            else
            {
                _maxValue = value;
            }
        }
    }
    #endregion

    #region Methods
    /// <summary>
    /// Empties the chest of items
    /// </summary>
    public void EmptyChest()
    {
        List<Item> tbRemoved = Items;
        foreach (Item item in tbRemoved)
        {
            Items.Remove(item);
        }
    }
    #endregion

}
