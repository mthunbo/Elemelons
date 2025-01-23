/// <summary>
/// Class that contains Item objects, with a limited storage space
/// </summary>
public class Backpack : Container
{
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