

/// <summary>
/// Base Monster class 
/// </summary>
public class Monster() : IMonster, ICharacter
{

    #region Fields
    private string _name = "";
    private double _attackPower = 10;
    private double _nativeDfense = 2;
    private int _expValue = 20;
    private int _level = 1;
    private double _currentHealth = 100;
    private double _maxHealth = 100;
    private bool _unalived = false;
    private bool _isAttackable = true;
    private Backpack? _loot = new(100);
    #endregion

    #region Properties
    public string Name { 
        get{ return _name;} 
        set{} }
    public double AttackPower { 
        get{ return _attackPower;} 
        set{} }
    public double NativeDefense { 
        get{ return _nativeDfense;} 
        set{} }
    public int ExpValue { 
        get{ return _expValue;} 
        set{}}
    public int Level { 
        get{ return _level;} 
        set{} }
    public double CurrentHealth { 
        get{ return _currentHealth;} 
        set{} }
    public double MaxHealth { 
        get{ return _maxHealth;} 
        set{} }
    public bool Unalived { 
        get{ return _unalived;} 
        set{} }
    public bool IsAttackable { 
        get{ return _isAttackable;} 
        set{} }
    public Backpack? Loot { 
        get{ return _loot;} 
        set{ _loot = value;} }
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
    public virtual void LevelUp()
    {
        MaxHealth *= 1.2;
        AttackPower *= 1.2;
        NativeDefense *= 1.2;
        ExpValue *= 2;
        Level += 1;
    }
    public override string ToString()
    {
        return $"{Name} lvl {Level} {this}";
    }
    #endregion
}