

public class Watermelon() : BaseMelon()
{

    #region Overridden Methods
    public override void LevelUp()
    {
        MaxHealth *= 1.3;
        AttackPower *= 1.2;
        NativeDefense *= 1.2;
        Level += 1;
        Experience -= 100;
    }
    #endregion
}