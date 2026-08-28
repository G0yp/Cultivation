using Godot;
using System;
// ( ͡° ᴥ ͡°)

public partial class CultivationStats : Resource
{
    [Export] public RealmConfig CurrentRealm { get; set; }
    public float qiGainFlat = 1f;
    public float qiGainMult = 1f;
    public float currentQi = 0f;

    public void ProcessQiGathering(float delta)
    {
        currentQi += (qiGainFlat * qiGainMult) * delta;
    }

    public bool CanAttemptBreakthrough()
    {
        return CurrentRealm != null && currentQi >= CurrentRealm.qiToBreakthrough;
    }

    public int Breakthrough()
    {
        if (CanAttemptBreakthrough() == True) { }
        return 1;
    }
}
