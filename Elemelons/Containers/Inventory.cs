

/// <summary>
/// Class representing the items equipped by the player
/// </summary>
public class Inventory : Container
{
    public Inventory(): base("Player Inventory")
    {

    }
    
    #region Fields
    private double _armorValue;
    private double _mgcArmorValue;
    private double _weaponDmg;
    private double _mgcWeaponDmg;
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
    /// Returns the magic armor value of the equipment in the inventory
    /// </summary>
    public double MgcArmorValue()
    {
        foreach (var item in _equipment)
        {
            _mgcArmorValue += item.Value.MagicDefense;            
        }
        return _mgcArmorValue;
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
    /// Returns the magic weapon damage of the weapons in the inventory
    /// </summary>
    public double MgcWeaponDmg()
    {
        foreach (var item in _equipment)
        {
            _mgcWeaponDmg += item.Value.MagicAttack;
        }
        return _mgcWeaponDmg;
    }

    /// <summary>
    /// Equips the given equipment if there isnt already one equipped of that type
    /// </summary>
    public override void AddEquipment(Equipment equipment)
    {
        if (_equipment.ContainsKey(equipment.Type))
        {
            throw new ArgumentException(equipment.Description + " a " + equipment.Type + " please unequip already equipped gear before attempting to equip a new one");
        }
        _equipment.Add(equipment.Description, equipment);
    }
    #endregion
}