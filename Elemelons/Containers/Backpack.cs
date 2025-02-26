/// <summary>
/// Class that contains Item objects, with a limited storage space
/// </summary>
public class Backpack : Container
{

    #region Fields
    private int _storageLimit;
    #endregion
    #region Constructors
    public Backpack(int storageLimit) : base("Backpack"){
        StorageLimit = storageLimit;
    }
    #endregion

    #region Properties
    /// <summary>
    /// Returns the value of all items in the Backpack
    /// </summary>
    public double BackpackValue{
        get{
            double value = 0;
            foreach (var item in Items)
            {
                value += item.Value;
            }
            return value;
        }
    }
    /// <summary>
    /// Returns the storage limit of the container
    /// </summary>
    public int StorageLimit
    {
        get => _storageLimit;
        set => _storageLimit = value > 0 ? value : 100;
    }

    /// <summary>
    /// Returns the amount of storage currently used
    /// </summary>
    public int StorageUsed => Items.Sum(item => item.Weight) + Equipment.Sum(eq => eq.Weight);

    /// <summary>
    /// Returns the storage space left in the container
    /// </summary>
    public int StorageLeft => StorageLimit - StorageUsed;
    #endregion


    #region Methods
    /// <summary>
    /// Overrides base version to check if there is room enough in the backpack
    /// </summary>
    public override void AddItem(Item item){
        if (item.Weight > StorageLeft){
            throw new ArgumentException("Looks like the backpack is full");
        }
        base.AddItem(item);
    }
    #endregion
}