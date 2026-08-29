using Godot;
using System;
// ( ͡° ᴥ ͡°)

[GlobalClass]
public partial class CultivationStats : Resource
{
    public RealmConfig BaseConfig;
    public CharacterProfile CharacterProfile;
    public float qiGainFlat = 1f;
    public float qiGainMult = 1f;
    public float currentQi = 0f;


    public void ProcessQiGathering()
    {
        currentQi += (qiGainFlat * qiGainMult);
    }

    public bool CanAttemptBreakthrough()
    {
        return BaseConfig != null && currentQi >= BaseConfig.QiToBreakthrough;
    }

    public bool Breakthrough()
    {
        if (CanAttemptBreakthrough())
        {
            RealmConfig.CultivationRealm realm = CurrentRealm;
            int statCap = CharacterProfile.StatCap;
            statCap = BaseConfig.CalculateStatCap(realm, statCap);
        }
        return false;
    }
}
