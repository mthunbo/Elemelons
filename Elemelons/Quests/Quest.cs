

using System.Reflection.Metadata;

/// <summary>
/// Base quest class
/// </summary>
public class Quest()
{
    #region Fields
    private string _name = "Error";
    private string _description = "Error";
    private int _difficulty = 1;
    private int _goldReward = 10;
    private List<Item> _itemReward = new();
    #endregion
    public string Name { 
        get{ return _name; } 
        set{ _name = value;} }
    public string Description { 
        get{ return _description; } 
        set{ _description = value; } }
    public int Difficulty { 
        get{ return _difficulty; } 
        set{ _difficulty = value; } }
    public int GoldReward { 
        get{ return _goldReward; } 
        set{ _goldReward = value; } }
    public List<Item> ItemReward { 
        get{ return _itemReward; } 
        set{ _itemReward = value; } }
}