using Godot;
using System;
using CultivationGame.Profile;

namespace CultivationGame.Core;

public partial class GameState : Node
{

    // Creates a globally accessible instance of CharacterProfile
    public static GameState Instance { get; private set; }

    public CharacterProfile PlayerProfile { get; set; }

    public override void _Ready()
    {
        Instance = this;
        PlayerProfile = new CharacterProfile();
    }


    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }
}
