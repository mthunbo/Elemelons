
/// <summary>
/// One of 4 classes, high defensive class
/// </summary>
public class EarthMelon() : BaseMelon()
{
    public override void LevelUp()
    {
        MaxHealth *= 1.2;
        AttackPower *= 1.2;
        NativeDefense *= 1.4;
        Level += 1;
        Experience -= 100;
    }
}