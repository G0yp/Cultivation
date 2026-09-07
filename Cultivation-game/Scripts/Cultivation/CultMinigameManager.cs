using Godot;
using System;
// ( ͡° ᴥ ͡°)

public partial class CultMinigameManager : Node
{
    public Label timerDisplay;
    public Timer countdownTimer;
    public Button testButton;


    public int time = 120;
    public float qiPerKill;
    public float totalKills;

    public override void _Ready()
    {
        timerDisplay = GetNode<Label>("%TimerDisplay");
        countdownTimer = GetNode<Timer>("%Timer");
        testButton = GetNode<Button>("%Button");

        testButton.Pressed += OnKill;
        countdownTimer.Timeout += OnTimerTimeout;

        timerDisplay.Text = $"{time}";


        qiPerKill = CharacterProfile.Instance.Cultivation.qiGainFlat * CharacterProfile.Instance.Cultivation.qiGainMult;
    }

    private void OnKill()
    {
        totalKills += 1;
    }

    private void OnTimerTimeout()
    {
        if (time > 0)
        {
            time -= 1;
            timerDisplay.Text = $"{time}";
        }
        else
        {
            CharacterProfile.Instance.Cultivation.currentQi += totalKills * qiPerKill;
        }
    }
}
