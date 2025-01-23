

/// <summary>
/// Class representing a Brigand, the brigand has a critical hit property
/// </summary>
public class Brigand(string name = "", double maxHealth = 100, double currentHealth = 100, double nativeDefense = 2, double attackPower = 10, int level = 1, bool unalived = false, bool isAttackable = true, int expValue = 20, Backpack loot = null) : Monster(name, maxHealth, currentHealth, nativeDefense, attackPower, level, unalived, isAttackable, expValue, loot)
{

    #region Properties
    /// <summary>
    /// Determines the % change of a Brigand doing a critical hit, set in % from 1 to 100, default is 10%
    /// </summary>
    private int CritChance { get; set; } = 10;
    /// <summary>
    /// Crit damage property, default is 20%
    /// </summary>
    private double CritDmg { get; set; } = 1.2;
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
    #endregion
}