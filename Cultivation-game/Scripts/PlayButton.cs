using Godot;
using System;

public partial class PlayButton : Godot.Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//make sure the button is not null before connecting
		if (PlayButton != null)
		{
			PlayButton.Pressed += OnPlayButtonPressed;
		}
	}
		//press button do something
	private void OnPlayButtonPressed()
	{
		GetTree().ChangeSceneToFile("res://Scenes/Tilemap.tscn");
	}
	public override void _ExitTree()
	{
			// When exit button press
			PlayButton.Pressed -= OnPlayButtonPressed;
		
	}
}
