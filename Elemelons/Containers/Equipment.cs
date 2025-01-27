
/// <summary>
/// Represents the equipment players can wear and use
/// Like Items it has a desscription, a weight, a value and additionally a Defense Value
/// </summary>
public class Equipment : Item
{
    
    #region Fields
    private string _type = "N/A";
    private double _defense = 1.0;
    private double _magicDefense = 1.0;
    private double _attack = 1.0;
    private double _magicAttack = 1.0;
    #endregion

    #region Constructor
    public Equipment(string type, double attack, double magicAttack, double defense, double magicDefense, string description)
    {
        Type = type;
        Attack = attack;
        MagicAttack = magicAttack;
        Defense = defense;
        MagicDefense = magicDefense;
        Description = description;
    }
    #endregion


    #region Properties
    public string Type { 
        get{ return _type; }
        set{ _type = value;} 
    }
    public double Attack { 
        get{ return _attack; }
        set
        {
            if (value < 0)
            {
                _attack = 0.0;
            }
            else
            {
                _attack = value;
            }
        }
    }
    public double MagicAttack { 
        get{ return _magicAttack; }
        set
        {
            if (value < 0)
            {
                _magicAttack = 0.0;
            }
            else
            {
                _magicAttack = value;
            }
        }
    }
    public double Defense { 
        get{ return _defense; }
        set
        {
            if(value < 0)
            {
                _defense = 0.0;
            }
            else
            {
                _defense = value;
            }
        }
    }
    public double MagicDefense { 
        get{ return _magicDefense; }
        set
        {
            if (value < 0)
            {
                _magicDefense = 0.0;
            }
            else
            {
                _magicDefense = value;
            }
        }
    }
    #endregion

    #region Methods
    public override string ToString()
    {
        return @$"{Description}
        Weight {Weight} Kg
        Worth  {Value} Gold
        Stats:
        Attack: {Attack} Dmg
        Magic Attack: {MagicAttack} Dmg
        Defense: {Defense}
        Magic Defense: {MagicDefense}";

    }
    #endregion
}