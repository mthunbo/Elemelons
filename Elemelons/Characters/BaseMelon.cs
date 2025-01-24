/// <summary>
/// Base class that the other melon classes inherit from
/// </summary>
public class BaseMelon : ICharacter, IPlayer
{
    #region Fields
    private string _name = "John Doe";
    private double _attackPower = 10;
    private double _nativeDfense = 2;
    private int _experience = 0;
    private int _level = 1;
    private double _currentHealth = 100;
    private double _maxHealth = 100;
    private bool _unalived = false;
    private bool _isAttackable = true;
    private Backpack? _backpack = new(100);
    private Inventory? _inventory = new();

    #endregion


    #region Properties
    public string Name { 
        get{ return _name; } 
        set{ _name = value; } }
    public double AttackPower { 
        get{ return _attackPower; }
        set{ _attackPower = value; } }
    public double NativeDefense { 
        get{ return _nativeDfense; } 
        set{ _nativeDfense = value; } }
    public int Experience { 
        get{ return _experience; } 
        set{ _experience = value;} }
    public int Level { 
        get{ return _level; } 
        set{ _level = value;} }
    public double CurrentHealth { 
        get{ return _currentHealth;} 
        set{ _currentHealth = value;} }
    public double MaxHealth { 
        get{ return _maxHealth; } 
        set{ _maxHealth = value;} }
    public bool Unalived { 
        get{ return _unalived; } 
        set{ _unalived = value;} }
    public bool IsAttackable { 
        get{ return _isAttackable; } 
        set{ _isAttackable = value;} }
    public Backpack? Backpack { 
        get{ return _backpack; } 
        set{ _backpack = value; } }
    public Inventory? Inventory { 
        get{ return _inventory; } 
        set{ _inventory = value;} }
    #endregion

    #region Methods
    public virtual double Attack()
    {
        return AttackModifier(AttackPower);
    }

    public virtual double AttackModifier(double damage)
    {
        double weaponPower = 0.0;
        if (Inventory.Equipment.Count == 0)
        {
            return damage;
        }
        List<Equipment> weapon = Inventory.Equipment;
        foreach (var item in weapon)
        {
            weaponPower += item.Attack;
        }
        return damage += weaponPower;
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

    public virtual double DefendModifier(double damage)
    {
        double defensePower = 0.0;
        if (Inventory.Equipment.Count == 0)
        {
            return damage -= NativeDefense;
        }
        List<Equipment> armor = Inventory.Equipment;
        foreach (var item in armor)
        {
            defensePower += item.Defense;
        }
        defensePower += NativeDefense;
        return damage -= defensePower;
    }

    public virtual void GainExperience(int experience)
    {
        if ((Experience += experience) >= 100)
        {
            Console.WriteLine($"Congrats on the level mate, you're now level {Level}, Press any key to continue...");

            LevelUp();
        }
        else
        {
            Experience += experience;
        }
    }

    public virtual void LevelUp()
    {
        MaxHealth *= 1.2;
        AttackPower *= 1.2;
        NativeDefense *= 1.2;
        Level += 1;
        Experience -= 100;
    }
    #endregion
}