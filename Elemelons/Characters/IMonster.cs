
/// <summary>
/// Interface containing properties for monsters
/// </summary>
interface IMonster
{
    /// <summary>
    /// Represents the experience the player gets for killing the monster
    /// </summary>
    int ExpValue { get; set; }
    /// <summary>
    /// Contains the loot possible to get from the monster
    /// </summary>
    Backpack? Loot { get; set; }
}