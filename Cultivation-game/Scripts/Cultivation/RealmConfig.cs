using Godot;
using System;
// ( ͡° ᴥ ͡°)

public enum CultivationRealm
{
    Mortal,
    QiRefining,
    FoundationEstablishment,
    CoreFormation,
    NascentSoul,
    TrueImmortal
}

public enum CultivationStage
{
    Lower,
    Middle,
    Upper,
    Peak,
}

[GlobalClass]
public partial class RealmConfig : Resource
{
    public CultivationRealm currentRealm = CultivationRealm.Mortal;

    var values = new Dictionary<int, int>
    {
        {0, 0},
        {1, 10},
        {2, 15},
        {3, 20},
        {4, 25},
        {5, 50},
    };

    public int StatCap => 10 + values[currentRealm];

    // breakthrough func go in CultivationStats

    public float qiGainFlat = 1f;
    public float qiGainMult = 1f;
    public float qiToBreakthrough = 100f;
}
