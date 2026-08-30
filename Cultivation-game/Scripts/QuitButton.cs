using Godot;
using System;

public partial class QuitButton : Godot.Button
{
	
	public QuitButton QuitButton1;
	public override void _Ready()
	{
		QuitButton1 = GetNode<QuitButton>("/root/Control/VBoxContainer/QuitButton");
		//make sure the button is not null before connecting
		if (QuitButton1 != null)
		{
			QuitButton1.Pressed += OnQuitButtonPressed;
		}
	}
		//press button do something
	private void OnQuitButtonPressed()
	{
		GetTree().Quit();
	}
	public override void _ExitTree()
	{
			// When exit button press
			QuitButton1.Pressed -= OnQuitButtonPressed;
		
	}
}