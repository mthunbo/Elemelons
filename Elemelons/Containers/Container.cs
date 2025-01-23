
/// <summary>
/// Base class for containing Item objects
/// </summary>
public class Container 
{
    #region Fields
    private string _description;
    private Dictionary<string, Item> _items;
    #endregion


    #region  Constructors
    public Container(string description)
    {
        _description = description;
        _items = new Dictionary<string, Item>();
        StorageLimit = 100;
    }
    #endregion


    #region Properties
    /// <summary>
    /// Returns all Item objects in the given container
    /// </summary>
    public List<Item> Items
    {
        get { return _items.Values.ToList(); }
    }

    /// <summary>
    /// Returns a description of the container
    /// </summary>
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    /// <summary>
    /// Returns the storage limit of the container
    /// </summary>
    public int StorageLimit { get; set; }

    /// <summary>
    /// Returns the amount of storage currently used
    /// </summary>
    public int StorageUsed
    {
        get
        {
            int storageUsed = 0;
            foreach (var item in Items)
            {
                storageUsed += item.Weight;
            }
            return storageUsed;
        }
    }

    /// <summary>
    /// Returns the storage space left in the container
    /// </summary>
    public int StorageLeft
    {
        get { return StorageLimit - StorageUsed; }
    }
    #endregion


    #region Methods
    /// <summary>
    /// Adds a given item object to the container
    /// Adds an "I" to the name if an item of the same name is already present
    /// </summary>
    public virtual void AddItem(Item item)
    {
        if(_items.ContainsKey(item.Description))
        {
            item.Description += "I";
        }
        _items.Add(item.Description, item);
    }

    /// <summary>
    /// Removes an item with the given description
    /// Throws an exception of there is no item with the given description
    /// </summary>
    public virtual Item RemoveItem(string description)
    {
        if(!_items.ContainsKey(description))
        {
            throw new ArgumentException(description + " is not present in the " + _description);
        }
        Item removedItem = _items[_description];
        _items.Remove(description);

        return removedItem;
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
    }
    #endregion
}