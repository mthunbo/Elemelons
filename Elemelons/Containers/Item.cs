

/// <summary>
/// This class represents an item which can be put into a container like a backpack.
/// An item has a description, a weight and a value.
/// </summary>
public class Item
{
    #region Fields
    private string _name = "";
    private string _description ="";
    private int _weight = 1;
    private int _value = 1;
    #endregion

    public Item(string name, string description, int weight = 1, int value = 1)
    {
        Name = name;
        Description = description;
        Weight = weight;
        Value = value;
    }


    #region Properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    /// <summary>
    /// Returns a description of the item
    /// </summary>
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    /// <summary>
    /// Returns the weight of the item, default is 1
    /// </summary>
    public int Weight
    {
        get => _weight;
        set => _weight = value > 0 ? value : 1;
    }

    /// <summary>
    /// Returns the value of the item, default is 1
    /// </summary>
    public int Value
    {
        get => _value;
        set => _value = value > 0 ? value : 1;
    }
    #endregion

    public override string ToString()
    {
        return $"{Name} : {Description} : {Weight} Kg : worth {Value} Gold";
    }
}
