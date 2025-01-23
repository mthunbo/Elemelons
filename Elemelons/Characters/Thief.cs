

/// <summary>
/// Class representing a Thief, the thief has a dodge property
/// </summary>
public class Thief(string name, double maxHealth, double currentHealth, double nativeDefense, double attackPower, int level, bool unalived, bool isAttackable, int expValue, Backpack loot) : Monster(name, maxHealth, currentHealth, nativeDefense, attackPower, level, unalived, isAttackable, expValue, loot)
{

    #region Poperties
    /// <summary>
    /// Determines the % change of a Thief dodging an attack, set in % from 1 to 100, default is 10%
    /// </summary>
    private int DodgeChance { get; set; } = 10;
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