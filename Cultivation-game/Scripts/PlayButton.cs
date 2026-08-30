using Godot;
using System;

public partial class PlayButton : Godot.Button
{
	
	public PlayButton PlayButton1;
	public override void _Ready()
	{
		PlayButton1 = GetNode<PlayButton>("/root/Control/VBoxContainer/PlayButton");
		//make sure the button is not null before connecting
		if (PlayButton1 != null)
		{
			PlayButton1.Pressed += OnPlayButtonPressed;
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
			PlayButton1.Pressed -= OnPlayButtonPressed;
		
	}
}
