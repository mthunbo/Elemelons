

public class EarthMelon(string name, double attackPower, double nativeDefense, int experience, int level, double currentHealth, double maxHealth, bool unalived, bool isAttackable, Backpack backpack, Inventory inventory) : BaseMelon(name, attackPower, nativeDefense, experience, level, currentHealth, maxHealth, unalived, isAttackable, backpack, inventory)
{
    public override void LevelUp()
    {
        MaxHealth *= 1.2;
        AttackPower *= 1.1;
        NativeDefense *= 1.4;
        Level += 1;
        Experience -= 100;
    }
}