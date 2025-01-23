

interface IPlayer
{
    #region Properties
    /// <summary>
    /// Current experience of the player, when it reaches 100 the player levels up
    /// </summary>
    int Experience { get; set; }
    /// <summary>
    /// Backpack of the player containing any and all items gotten throughout the game
    /// </summary>
    Backpack Backpack{ get; set; }
    /// <summary>
    /// Inventory of the player, contains the armor the player is wearing
    /// </summary>
    Inventory Inventory{ get; set; }
    #endregion

    #region Methods
    /// <summary>
    /// Levels up the player once experience reaches 100
    /// </summary>
    void LevelUp();
    #endregion
}