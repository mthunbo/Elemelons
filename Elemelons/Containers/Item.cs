

/// <summary>
/// This class represents an item which can be put into a container like a backpack.
/// An item has a description, a weight and a value.
/// </summary>
public class Item
{
    #region Fields
    private string _description ="";
    private int _weight = 1;
    private double _value = 1.0;
    #endregion

    public Item(string description, int weight, int value)
    {
        Description = description;
        Weight = weight;
        Value = value;
    }

    #region Properties
    public string Description { 
        get{ return _description; } 
        set{ _description = value; } }
    public int Weight { 
        get{ return _weight; } 
        set
        { 
            if(value <= 0)
            {
            _weight = 1;
            }
            else
            {
                _weight = value;
            }
        }
    }
    public double Value { 
        get{ return _value; }
        set
        {
            if(value <= 0)
            {
                _value = 1;
            }
            else
            {
                _value = value;
            }
        }
    }
    #endregion

    public override string ToString()
    {
        return $"{Description} : weight {Weight}, worth {Value}";
    }
}
