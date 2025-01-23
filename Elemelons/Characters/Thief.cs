

/// <summary>
/// Class representing a Thief, the thief has a dodge property
/// </summary>
public class Thief() : Monster()
{

    #region Fields
    private int _dodgeChance = 10;
    #endregion
    
    #region Poperties
    /// <summary>
    /// Determines the % change of a Thief dodging an attack, set in % from 1 to 100, default is 10%
    /// </summary>
    public int DodgeChance { 
        get{ return _dodgeChance; } 
        set{} }
    #endregion

    #region Methods
    public override void Defend(double damage)
    {
        Random rand = new();
        if (!(rand.Next(1, 101) <= DodgeChance))
        {
            CurrentHealth -= DefendModifier(damage);
        }
    }
    #endregion
}