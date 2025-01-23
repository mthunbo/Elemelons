

public class EarthMelon() : BaseMelon()
{
    public override void LevelUp()
    {
        MaxHealth *= 1.2;
        AttackPower *= 1.1;
        NativeDefense *= 1.4;
        Level += 1;
        Experience -= 100;
    }
}