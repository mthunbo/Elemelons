/// <summary>
/// One of 4 classes, unique Dodge class 
/// </summary>
public class AirMelon() : BaseMelon()
{
    #region Fields
    private double _dodgeChance = 10;
    #endregion
    
    #region Properties
    /// <summary>
    /// Dodge chance property, default and base level is 10%
    /// </summary>
    public double DodgeChance {
        get{ return _dodgeChance; } 
        set{} }
    #endregion



    #region Overridden Methods
    public override void Defend(double damage)
    {
        Random rand = new();
        if (!(rand.Next(1,101) <= DodgeChance))
        {
            CurrentHealth -= DefendModifier(damage);
        }
    }
    public override void LevelUp()
    {
        MaxHealth *= 1.1;
        AttackPower *= 1.4;
        NativeDefense *= 1.1;
        Level += 1;
        Experience -= 100;
    }
    #endregion
}