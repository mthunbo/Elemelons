

public class Watermelon(string name, double attackPower, double nativeDefense, int experience, int level, double currentHealth, double maxHealth, bool unalived, bool isAttackable, Backpack backpack, Inventory inventory) : BaseMelon(name, attackPower, nativeDefense, experience, level, currentHealth, maxHealth, unalived, isAttackable, backpack, inventory)
{

    #region Overridden Methods
    public override void LevelUp()
    {
        MaxHealth *= 1.3;
        AttackPower *= 1.2;
        NativeDefense *= 1.2;
        Level += 1;
        Experience -= 100;
    }
    #endregion
}