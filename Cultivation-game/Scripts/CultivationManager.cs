using Godot;
using System;

public partial class CultivationManager : Node
{
    [Export] public CharacterStatistics CharStats { get; set; }
    private Button cultivateButton;
    private ProgressBar cultivationProgress;
    public bool cultivateActive = false;

    private float qiGainRate;

    public override async void _Ready()
    {
        cultivateButton = GetNode<Button>("HBoxContainer/VBoxContainer2/HBoxContainer/CultivationButton");
        cultivateButton.Pressed += ButtonPressed;
        cultivationProgress = GetNode<ProgressBar>("HBoxContainer/VBoxContainer2/ProgressBar");

        if (CharStats != null)
        {
            cultivationProgress.MaxValue = CharStats.qiToBreakthrough;
        }
    }

    private void ButtonPressed()
    {
        if (CharStats == null) return;
        cultivateActive = !cultivateActive;

        if(cultivateActive)
        {
            QiCultivation();
        }
    }

    private async void QiCultivation()
    {
        while (cultivateActive)
        {
            qiGainRate = CharStats.qiGainFlat * CharStats.qiGainMult;
            CharStats.currentQi += qiGainRate;

            cultivationProgress.Value = Math.Min(CharStas.currentQi, cultivationProgress.MaxValue);

            if (CharStats.currentQi >= CharStats.qiToBreakthrough)
            {
                TriggerBreakthrough();
            }

            await ToSignal(GetTree().CreateTimer(1.0f), SceneTreeTimer.SignalName.Timeout);
        }
    }

    private void TriggerBreakthrough()
    {
        CharStats.currentQi = 0;

        if (CharStats.currentRealm < 3 && CharStats.currentStage > 2)
        {
            CharStats.currentRealm += 1;
            CharStats.currentStage = 1;
            CharStats.qiToBreakthrough *= 5f;
        }
        else if (CharStats.currentRealm > 2 && CharStats.currentStage > 3)
        {
            CharStats.currentRealm += 1;
            CharStats.currentStage = 1;
            CharStats.qiToBreakthrough *= 5f;
        }
        else
        {
            CharStats.qiToBreakthrough *= 1.5f;
        }

        cultivationProgress.MaxValue = CharStats.qiToBreakthrough;
        cultivationProgress.Value = 0;
    }

    // realms p1
    // techniques p3
    // dao p3
    // foundation p1
    // stats will be in a StatManager script
    // reincarnation p2
}
