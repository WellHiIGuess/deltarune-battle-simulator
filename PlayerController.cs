using Godot;
using System;

public partial class PlayerController : RigidBody2D
{
	float speed = 5;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 move = new Vector2
		{
			X = Input.GetActionStrength("ui_right") - Input.GetActionStrength("ui_left"),
			Y = Input.GetActionStrength("ui_down") - Input.GetActionStrength("ui_up")
		};

		MoveAndCollide(move * speed);
		GD.Print(LinearVelocity);
	}
}
