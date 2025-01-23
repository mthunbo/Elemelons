

/// <summary>
/// Interface for the NPC class
/// </summary>
interface INPC : ICharacter
{
    /// <summary>
    /// Inventory in case the NPC is a store owner
    /// </summary>
    Backpack ShopIventory { get; set; }
    /// <summary>
    /// Quests the NPC might have for the player
    /// </summary>
    Quest Quest{ get; set; }
}