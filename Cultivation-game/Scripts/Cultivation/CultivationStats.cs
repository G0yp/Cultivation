using CultivationGame.Core;
using Godot;
using System;
// ( ͡° ᴥ ͡°)

namespace CultivationGame.Cultivation;

public partial class CultivationStats : Resource
{
    public RealmConfig BaseConfig;
    public float realmProgress = 0f; // How close the player is to advancing
    public float qiGainFlat = 1f;
    public float qiGainMult = 1f;
    public float currentQi = 0f;

    public RealmConfig.CultivationRealm CurrentRealm = RealmConfig.CultivationRealm.Mortal;
    public RealmConfig.CultivationStage CurrentStage = RealmConfig.CultivationStage.Lower;

    public bool CanAttemptBreakthrough()
    {
        return realmProgress >= BaseConfig.QiToBreakthrough;
    }

    // Breakthrough by checking if realm is complete
    public bool Breakthrough()
    {
        if (CanAttemptBreakthrough() && CurrentStage == RealmConfig.CultivationStage.Peak)
        {
            CurrentRealm += 1;
            GameState.Instance.PlayerProfile.StatCap = RealmConfig.CalculateStatCap(CurrentRealm, GameState.Instance.PlayerProfile.StatCap);
            return true;
        }
        return false;
    }

    public bool IncreaseStage()
    {
        if (CanAttemptBreakthrough() && CurrentStage != RealmConfig.CultivationStage.Peak)
        {
            CurrentStage += 1;
            GameState.Instance.PlayerProfile.StatCap = RealmConfig.CalculateStatCap(CurrentRealm, GameState.Instance.PlayerProfile.StatCap);
            return true;
        }
        return false;

    }
}
