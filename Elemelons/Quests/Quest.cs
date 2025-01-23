

/// <summary>
/// Base quest class
/// </summary>
public class Quest(string name, string description, int difficulty, int goldReward, Item itemReward)
{
    string Name { get; set; } = name;
    string Description { get; set; } = description;
    int Difficulty { get; set; } = difficulty;
    int GoldReward { get; set; } = goldReward * difficulty;
    Item ItemReward { get; set; } = itemReward;
}