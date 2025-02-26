
/// <summary>
/// Base class for containing Item objects
/// </summary>
public class Container 
{
    #region Fields
    private string _description;
    protected Dictionary<string, Item> _items;
    protected Dictionary<string, Equipment> _equipment;
    #endregion


    #region  Constructors
    public Container(string description)
    {
        _description = description;
        _items = [];
        _equipment = [];
    }
    #endregion


    #region Properties
    /// <summary>
    /// Returns all Item objects in the given container
    /// </summary>
    public List<Item> Items => [.. _items.Values];
    public List<Equipment> Equipment => [.. _equipment.Values];

    /// <summary>
    /// Returns a description of the container
    /// </summary>
    public string Description
    {
        get => _description;
        set => _description = value;
    }
    #endregion


    #region Methods
    /// <summary>
    /// Adds a given item object to the container
    /// Adds an "I" to the name if an item of the same name is already present
    /// </summary>
    public virtual void AddItem(Item item)
    {
        if (_items.ContainsKey(item.Description))
        {
            item.Description += "I";
        }
        _items.Add(item.Description, item);
    }
    /// <summary>
    /// Adds a given equipment object to the container
    /// Adds an "I" to the name if equipment of the same name is already present
    /// </summary>
    public virtual void AddEquipment(Equipment equipment)
    {
        if (_equipment.ContainsKey(equipment.Description))
        {
            equipment.Description += "I";
        }
        _equipment.Add(equipment.Description, equipment);
    }

    /// <summary>
    /// Removes an item with the given description
    /// Throws an exception if there is no item with the given description
    /// </summary>
    public virtual Item RemoveItem(string description)
    {
        if (!_items.ContainsKey(description))
        {
            throw new ArgumentException($"{description} is not present in {_description}");
        }
        Item removedItem = _items[description];
        _items.Remove(description);
        return removedItem;
    }

    /// <summary>
    /// Removes Equipment with the given description
    /// Throws an exception if there is no Equipment with the given description
    /// </summary>
    public virtual Equipment RemoveEquipment(string description)
    {
        if (!_equipment.TryGetValue(description, out Equipment removedEquipment))
            throw new ArgumentException($"{description} is not present in {_description}");

        _equipment.Remove(description);
        return removedEquipment;
    }

    /// <summary>
    /// Prints the contents of the container
    /// </summary>
    public virtual void PrintContent()
    {
        Console.WriteLine($"--- Items found in {_description} ---");
        foreach (Item item in Items)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"------- Equipment found -------");
        foreach (Equipment equipment in Equipment)
        {
            Console.WriteLine(equipment);
        }
    }
    #endregion
}