
/// <summary>
/// Represents the equipment players can wear and use
/// Like Items it has a desscription, a weight, a value and additionally a Defense Value
/// </summary>
public class Equipment(string description, int weight, double value, string type, double defense, double magicDefense, double attack, double magicAttack) : Item(description, weight, value)
{
    #region Properties
    public string Type { get; set; } = type;
    public double Defense { get; set; } = defense;
    public double MagicDefense { get; set; } = magicDefense;
    public double Attack { get; set;} = attack;
    public double MagicAttack { get; set; } = magicAttack;
    #endregion
}