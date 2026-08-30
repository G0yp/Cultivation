using Godot;
using System;
// ( ͡° ᴥ ͡°)

public partial class CultMinigameManager : Node
{
    public Label timerDisplay;
    public Timer countdownTimer;
    public Button testButton;
    public CultivationStats cultStats;


    public int time = 120;
    public float qiPerKill;
    public float totalKills;

    public override void _Ready()
    {
        timerDisplay = GetNode<Label>("/root/CultivationMinigame/Player/TimerDisplay");
        countdownTimer = GetNode<Timer>("/root/CultivationMinigame/Timer");
        testButton = GetNode<Button>("/root/CultivationMinigame/Button");

        cultStats = GetNode<CultivationStats>("/root/CultivationMinigame/Node");

        testButton.Pressed += OnKill;
        countdownTimer.Timeout += OnTimerTimeout;

        timerDisplay.Text = $"{time}";


        qiPerKill = cultStats.qiGainFlat * cultStats.qiGainMult;
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
            cultStats.currentQi += totalKills * qiPerKill;
        }
    }
}
