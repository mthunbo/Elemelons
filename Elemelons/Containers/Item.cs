

/// <summary>
/// This class represents an item which can be put into a container like a backpack.
/// An item has a description, a weight and a value.
/// </summary>
public class Item(string description, int weight, double value)
{
    #region Properties
    public string Description { get; set; } = description;
    public int Weight { get; set; } = weight;
    public double Value { get; set; } = value;

    #endregion
    #region Constructor
    #endregion

    public override string ToString()
    {
        return $"{Description} : weight {Weight}, worth {Value}";
    }
}
