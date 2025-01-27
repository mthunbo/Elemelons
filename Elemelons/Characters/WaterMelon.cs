
/// <summary>
/// One of 4 classes, most balanced class
/// </summary>
public class Watermelon(string name) : BaseMelon(name)
{

    #region Overridden Methods
    public override void LevelUp()
    {
        MaxHealth *= 1.3;
        AttackPower *= 1.3;
        NativeDefense *= 1.3;
        Level += 1;
        Experience -= 100;
    }
    #endregion
}