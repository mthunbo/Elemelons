
/// <summary>
/// Chest class that will contain items as a reward for the player
/// </summary>
public class Chest :Container
{

    public Chest(int maxValue) : base("Chest")
    {
        MaxValue = maxValue;
    }

    #region Properties
    /// <summary>
    /// Max combined value of all items in the chest
    /// </summary>
    private int MaxValue { get; set; }
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
