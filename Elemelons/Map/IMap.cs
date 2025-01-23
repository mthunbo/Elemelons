
/// <summary>
/// Interface for the different maps
/// </summary>
public interface IMap
{
    #region Properties
    /// <summary>
    /// Name of the map
    /// </summary>
    string Name { get; set; }
    /// <summary>
    /// Description of the map
    /// </summary>
    string Description { get; set; }
    /// <summary>
    /// TUI Layout for the map
    /// </summary>
    List<string> Layout { get; set; }
    #endregion


    #region Methods
    /// <summary>
    /// Searches the area to see if any chests or enemies are present
    /// </summary>
    void Search();
    /// <summary>
    /// Prints a description/console representation of the current map
    /// </summary>
    void PrintMap();
    #endregion
}