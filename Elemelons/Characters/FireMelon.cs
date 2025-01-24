
/// <summary>
/// One of 4 classes, unique Crit class
/// </summary>
public class FireMelon() : BaseMelon()
{
    #region Fields
    private int _critChance = 10;
    private double _critDmg = 1.2;
    #endregion

    #region Properties
    /// <summary>
    /// Determines the % change of a FireMelon doing a critical hit, set in % from 1 to 100, default is 10%
    /// </summary>
    public int CritChance { 
        get{ return _critChance; } 
        set{} }
    /// <summary>
    /// Crit damage property, default is 20%
    /// </summary>
    public double CritDmg { 
        get{ return _critDmg; } 
        set{} }
    #endregion


    #region Methods
    public override double AttackModifier(double damage)
    {
        Random rand = new();
        if (rand.Next(1, 101) <= CritChance)
        {
            return damage *= CritDmg;
        }
        return damage;
    }
    public override void LevelUp()
    {
        MaxHealth *= 1.2;
        AttackPower *= 1.3;
        NativeDefense *= 1.1;
        Level += 1;
        Experience -= 100;
    }
    #endregion
}