using Godot;
using System;

public enum CultivationRealm
{
    Mortal,
    QiRefining,
    FoundationEstablishment,
    CoreFormation,
    NascentSoul,
    TrueImmortal
}

[GlobalClass]
public partial class RealmConfig : Resource
{
    public CultivationRealm currentRealm = CultivationRealm.Mortal;
    /* if we want different stat values we can use a dictionary like this
    var values = new Dictionary<int, int>
    {
        {1, 10},
        {2, 30},
        {3, 60},
        {4, 100},
        {5, 150},
        {6, 210}
    };*/

    public int statCap = 5*(currentRealm)^2 + 5*currentRealm;
    public float qiGainFlat = 1f;
    public float qiGainMult = 1f;
    public float qiToBreakthrough = 100f;
}
