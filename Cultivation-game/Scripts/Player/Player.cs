using Godot;
using System;


public partial class Player : CharacterBody2D{

	// Base speed which gets modified
	[Export]
	public float BaseSpeed;
	// Speed modifier
	[Export]
	public float Sprint;
	[Export]
	public float DashDistance;
    // Internal speed
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
		if(Input.IsActionJustPressed("Dash")){
			if (direction != Vector2.Zero){
				Position += direction * DashDistance;
			}
		}
		Velocity = velocity;
		MoveAndSlide();
	}
}
