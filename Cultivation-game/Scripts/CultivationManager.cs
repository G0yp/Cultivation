using Godot;
using System;

public partial class CultivationManager : Node
{
    private Button cultivateButton;
    private ProgressBar cultivationProgress;
    public bool cultivateActive = false;
    public float qiGainFlat = 1f;
    public float qiGainMult = 1f;
    private float qiGainRate;
    private float currentQi;

    public override async void _Ready()
    {
        cultivateButton = GetNode<Button>("HBoxContainer/VBoxContainer2/HBoxContainer/CultivationButton");
        cultivateButton.Pressed += ButtonPressed;
        cultivationProgress = GetNode<ProgressBar>("HBoxContainer/VBoxContainer2/ProgressBar");
        currentQi = 0;
    }

    private void ButtonPressed()
    {
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
            qiGainRate = qiGainFlat * qiGainMult;
            currentQi += qiGainRate;

            cultivationProgress.Value = currentQi;

            await ToSignal(GetTree().CreateTimer(1.0f), SceneTreeTimer.SignalName.Timeout);
        }
    }

    // realms p1
    // body cultivation p1
    // techniques p3
    // dao p3
    // foundation p1
    // stats will be in a StatManager script
    // reincarnation p2
}
