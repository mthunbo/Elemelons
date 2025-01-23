
/// <summary>
/// Base character interface, contains shared properties for all character classes e.g. Thief, FireMelon
/// </summary>
interface ICharacter
{
    #region Properties
    /// <summary>
    /// Name of the character
    /// </summary>
    string Name { get; set;}
    /// <summary>
    /// Max Health of the character
    /// </summary>
    double MaxHealth { get; set;}
    /// <summary>
    /// Current Health of the character
    /// </summary>
    double CurrentHealth { get; set;}
    /// <summary>
    /// The Defense value of a player without any armor
    /// </summary>
    double NativeDefense { get; set; }
    /// <summary>
    /// Attack power of the character
    /// </summary>
    double AttackPower { get; set;}
    /// <summary>
    /// Level of the character
    /// </summary>
    int Level { get; set;}
    /// <summary>
    /// Check to see if the character is alive
    /// </summary>
    bool Unalived { get; set;}
    /// <summary>
    /// Check to see if the chracter is attackable
    /// </summary>
    bool IsAttackable { get; set;}
    #endregion

    #region Methods
    /// <summary>
    /// Attack method that returns the damage to be sent to the enemy
    /// </summary>
    double Attack();
    /// <summary>
    /// Defends the character during an attack, removes the damage from the current health
    /// </summary>
    void Defend(double damage);
    /// <summary>
    /// Attack modifier that changes the damage of an attack according to various properties
    /// </summary>
    double AttackModifier(double damage);
    /// <summary>
    /// Defense modifier that changes the damage of an incoming attack according to various properties
    /// </summary>
    double DefendModifier(double damage);
    #endregion
}