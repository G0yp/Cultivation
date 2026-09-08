using Godot;
using System;
// ( ͡° ᴥ ͡°)

namespace CultivationGame.Cultivation;

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

    public const int StatCap = 10;
    public static int CalculateStatCap(CultivationRealm currentRealm, int statCap)
    {
        int[] statCapValues = [0, 10, 15, 20, 25, 50];

        int baseStatCap = statCapValues[(int)currentRealm];
        return statCap + baseStatCap;
    }

    public float QiToBreakthrough = 100f;
}
