

public class City(string name, string description)
{

    #region Properties
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    #endregion


    #region Methods
    public override string ToString()
    {
        return $"Welcome to {Name}, the city known for {Description}";
    }
    #endregion

}