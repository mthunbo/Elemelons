
/// <summary>
/// Represents the equipment players can wear and use
/// Like Items it has a desscription, a weight, a value and additionally a Defense Value
/// </summary>
public class Equipment : Item
{
    
    #region Fields
    private string _type = "N/A";
    private double _attack = 0.0;
    private double _magicAttack = 0.0;
    private double _defense = 0.0;
    private double _magicDefense = 0.0;
    private string _rarity = "Common";
    private int _durability = 100;
    private int _maxDurability = 100;
    #endregion

    #region Constructor
    public Equipment(string type, double attack, double magicAttack, double defense, double magicDefense,
                     string name, string description, int weight, int value,
                     int durability = 100, int maxDurability = 100, string rarity = "Common") 
        :base(name, description, weight, value)
    {
        Type = type;
        Attack = attack;
        MagicAttack = magicAttack;
        Defense = defense;
        MagicDefense = magicDefense;
        Rarity = rarity;
        Durability = durability;
        MaxDurability = maxDurability;
    }
    #endregion


    #region Properties
    public string Type 
    { 
        get{ return _type; }
        set{ _type = value;} 
    }
    public double Attack
    {
        get => _attack;
        set => _attack = Math.Max(0, value);
    }
    public double MagicAttack
    {
        get => _magicAttack;
        set => _magicAttack = Math.Max(0, value);
    }
    public double Defense
    {
        get => _defense;
        set => _defense = Math.Max(0, value);
    }
    public double MagicDefense
    {
        get => _magicDefense;
        set => _magicDefense = Math.Max(0, value);
    }
    public string Rarity {
        get{ return _rarity; }
        set{ _rarity = value;}
    }
    public int Durability
    {
        get => _durability;
        set => _durability = Math.Min(value, MaxDurability);
    }
    public int MaxDurability
    {
        get => _maxDurability;
        set => _maxDurability = Math.Max(1, value);
    }
    #endregion

    #region Methods
    /// <summary>
    /// Scales the stats of the equipment according to its rarity
    /// </summary>
    public void ScaleStats()
    {
        double rarityMultiplier = Rarity switch
        {
            "Common" => 1.0,
            "Uncommon" => 1.2,
            "Rare" => 1.5,
            "Epic" => 2.0,
            "Legendary" => 3.0,
            _ => 1.0
        };

        Attack *= rarityMultiplier;
        MagicAttack *= rarityMultiplier;
        Defense *= rarityMultiplier;
        MagicDefense *= rarityMultiplier;
        
    }
    public override string ToString()
    {
        return @$"
        {Name}
        {Description}
        {Rarity} {Type}
        Weight {Weight} Kg
        Worth  {Value} Gold
        Stats:
        Attack: {Attack} Dmg
        Magic Attack: {MagicAttack} Dmg
        Defense: {Defense}
        Magic Defense: {MagicDefense}
        Durability: {Durability}/{MaxDurability}";

    }
    #endregion
}