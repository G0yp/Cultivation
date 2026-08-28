using Godot;
using System;

[Tool]
public partial class Player : CharacterBody2D{
	/// <summary>
	/// Sets base speed of character before modification
	/// </summary>
	[Export]
	public float BaseSpeed;

	[Export]
	public float Sprint;

	float speed;

	public override void _PhysicsProcess(double delta){
		Vector2 velocity = Velocity;

		if(Input.IsActionPressed("Sprint")){
			speed = BaseSpeed + Sprint;
		}
		else {
			speed = BaseSpeed;
		}
		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		if (direction != Vector2.Zero){
			velocity.X = direction.X * speed;
			velocity.Y = direction.Y * speed;
		}
		else{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, speed);
			velocity.Y = Mathf.MoveToward(Velocity.Y, 0, speed);
		}

		Velocity = velocity;
		MoveAndSlide();
	}
}
