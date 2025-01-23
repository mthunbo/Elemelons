

/// <summary>
/// Base Monster class 
/// </summary>
public class Monster(string name = "", double maxHealth = 100, double currentHealth = 100, double nativeDefense = 2, double attackPower = 10, int level = 1, bool unalived = false, bool isAttackable = true, int expValue = 20, Backpack loot = null) : IMonster, ICharacter
{
    #region Properties
    public string Name { get; set; } = name;
    public double MaxHealth { get; set; } = maxHealth;
    public double CurrentHealth { get; set; } = currentHealth;
    public double NativeDefense { get; set; } = nativeDefense;
    public double AttackPower { get; set; } = attackPower;
    public int Level { get; set; } = level;
    public int ExpValue { get; set;} = expValue;
    public bool Unalived { get; set; } = unalived;
    public bool IsAttackable { get; set; } = isAttackable;
    public Backpack Loot { get; set;} = loot;
    #endregion


    #region Methods
    public double Attack()
    {
        return AttackModifier(AttackPower);
    }

    public virtual void Defend(double damage)
    {
        if (DefendModifier(damage) >= CurrentHealth)
        {
            Unalived = true;
        }
        else
        {
            CurrentHealth -= DefendModifier(damage);
        }
    }

    public virtual double AttackModifier(double damage)
    {
        return damage;
    }

    public double DefendModifier(double damage)
    {
        return damage -= NativeDefense;
    }
    public override string ToString()
    {
        return $"{Name} lvl {Level} {this}";
    }
    #endregion
}