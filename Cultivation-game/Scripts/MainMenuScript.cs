using Godot;
using System;

public partial class MainMenuScript : Node2D
{
	[Export] 
	private Node2D Settings;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Settings = GetNode<Node2D>("/root/Scenes/MainMenu.tscn/HideableNode");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public void HideSettings()
	{
		Settings.Visible = false;
	}
}
