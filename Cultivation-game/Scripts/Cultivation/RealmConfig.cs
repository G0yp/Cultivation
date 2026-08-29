using Godot;
using System;
// ( ͡° ᴥ ͡°)

[GlobalClass]
public partial class RealmConfig : Resource
{
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
        Lower = 1,
        Middle,
        Upper,
        Peak,
    }


    public CultivationRealm CurrentRealm = CultivationRealm.Mortal;
    public CultivationStage CurrentStage = CultivationStage.Lower;



    public const int StatCap = 10;
    public static int CalculateStatCap(int currentRealm, int statCap)
    {
        int[] statCapValues = [0, 10, 15, 20, 25, 50];
        int baseStatCap = statCapValues[currentRealm];
        return statCap + baseStatCap;
    }

    public float QiGainFlat = 1f;
    public float QiGainMult = 1f;
    public float QiToBreakthrough = 100f;
}
