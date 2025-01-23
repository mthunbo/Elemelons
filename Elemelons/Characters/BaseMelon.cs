

public class BaseMelon(string name ="John Doe", double attackPower = 10, double nativeDefense = 2, int experience = 0, int level = 1, double currentHealth = 100, double maxHealth = 100, bool unalived = false, bool isAttackable = true, Backpack backpack = null, Inventory inventory = null) : ICharacter, IPlayer
{
    public string Name { get; set; } = name;
    public double MaxHealth { get; set; } = maxHealth;
    public double CurrentHealth { get; set; } = currentHealth;
    public double NativeDefense { get; set; } = nativeDefense;
    public double AttackPower { get; set; } = attackPower;
    public int Level { get; set; } = level;
    public bool Unalived { get; set; } = unalived;
    public bool IsAttackable { get; set; } = isAttackable;
    public int Experience { get; set; } = experience;
    public Backpack? Backpack { get; set; } = backpack;
    public Inventory Inventory { get; set; } = inventory;

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
}