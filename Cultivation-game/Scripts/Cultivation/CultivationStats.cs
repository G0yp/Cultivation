using Godot;
using System;
// ( ͡° ᴥ ͡°)

public partial class CultivationStats : Resource
{
    public RealmConfig BaseConfig;
    public float realmProgress = 0f; // How close the player is to advancing

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
            CharacterProfile.Instance.StatCap = RealmConfig.CalculateStatCap(CurrentRealm, CharacterProfile.Instance.StatCap);
        }
        return false;
    }

    public bool IncreaseStage()
    {
        if (CanAttemptBreakthrough() && CurrentStage != RealmConfig.CultivationStage.Peak)
        {
            CurrentStage += 1;
            CharacterProfile.Instance.StatCap = RealmConfig.CalculateStatCap(CurrentRealm, CharacterProfile.Instance.StatCap);
        }

    }
}
