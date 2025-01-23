

/// <summary>
/// Class representing the items equipped by the player
/// </summary>
public class Inventory : Container
{
    public Inventory(): base("Player Inventory")
    {

    }
    
    #region Fields
    private Dictionary<string, Equipment> _equipment = new Dictionary<string, Equipment>();
    private double _armorValue;
    private double _weaponDmg;
    #endregion

    #region Properties
    /// <summary>
    /// Returns all equipment in the inventory
    /// </summary>
    public List<Equipment> Equipment
    {
        get { return _equipment.Values.ToList(); }
    }
    #endregion

    #region Methods
    /// <summary>
    /// Returns the armor value of the equipment in the inventory
    /// </summary>
    public double ArmorValue()
    {
        foreach (var item in _equipment)
        {
            _armorValue += item.Value.Attack;
        }
        return _armorValue;
    }

    /// <summary>
    /// Returns the weapon damage of the weapons in the inventory
    /// </summary>
    public double WeaponDmg()
    {
        foreach (var item in _equipment)
        {
            _weaponDmg += item.Value.Attack;
        }
        return _weaponDmg;
    }

    /// <summary>
    /// Equips the given equipment if there isnt already one equipped of that type
    /// </summary>
    public void AddEquipment(Equipment equipment)
    {
        if (_equipment.ContainsKey(equipment.Type))
        {
            throw new ArgumentException(equipment.Description + " a " + equipment.Type + " please unequip already equipped gear before attempting to equip a new one");
        }
        _equipment.Add(equipment.Description, equipment);
    }
    #endregion
}