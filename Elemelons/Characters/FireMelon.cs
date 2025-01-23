

public class FireMelon(string name, double attackPower, double nativeDefense, int experience, int level, double currentHealth, double maxHealth, bool unalived, bool isAttackable, Backpack backpack, Inventory inventory) : BaseMelon(name, attackPower, nativeDefense, experience, level, currentHealth, maxHealth, unalived, isAttackable, backpack, inventory)
{

    #region Properties
    /// <summary>
    /// Determines the % change of a FireMelon doing a critical hit, set in % from 1 to 100, default is 10%
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