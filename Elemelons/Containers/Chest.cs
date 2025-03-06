
/// <summary>
/// Chest class that will contain items as a reward for the player
/// </summary>
public class Chest :Container
{
    #region Fields
    private int _maxValue = 100;
    #endregion

    #region Constructors
    public Chest(int maxValue) : base("Chest")
    {
        MaxValue = maxValue;
    }
    #endregion

    #region Properties
    /// <summary>
    /// Max combined value of all items in the chest
    /// </summary>
    public int MaxValue
    {
        get => _maxValue;
        set => _maxValue = value >= 100 ? value : 100;
    }

    public int CurrentValue => Items.Sum(item => item.Value) + Equipment.Sum(eq => eq.Value);
    #endregion

    #region Methods
    public override void AddItem(Item item)
    {
        if (CurrentValue + item.Value <= MaxValue)
        {
            base.AddItem(item);
        }
        else
        {
            throw new InvalidOperationException("Adding this item exceeds the chest's max value.");
        }
    }
    public override void AddEquipment(Equipment equipment)
    {
        if (CurrentValue + equipment.Value <= MaxValue)
        {
            base.AddEquipment(equipment);
        }
        else
        {
            throw new InvalidOperationException("Adding this equipment exceeds the chest's max value.");
        }
    }

    /// <summary>
    /// Empties the chest of items
    /// </summary>
    public void EmptyChest()
    {
        var itemDescriptions = Items.Select(i => i.Description).ToList();
        var equipmentDescriptions = Equipment.Select(e => e.Description).ToList();

        foreach (var desc in itemDescriptions)
            RemoveItem(desc);

        foreach (var desc in equipmentDescriptions)
            RemoveEquipment(desc);
    }
    #endregion

}
