using Godot;
using System;
using System.Drawing;

public partial class Movement : CharacterBody2D
{
	[Export] private int speed;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GetChild<AnimatedSprite2D>(2).Play();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Move();
		CheckCollision();
	}

	public void Move() {
		if (Input.IsKeyPressed(Key.D)) {
			 
			Position += new Vector2(speed, 0); 
			GetChild<AnimatedSprite2D>(2).Scale = new Vector2(2, 2);
		}
		if (Input.IsKeyPressed(Key.A)) {
			Position += new Vector2(-speed, 0); 
			GetChild<AnimatedSprite2D>(2).Scale = new Vector2(-2, 2);
		}
		if (Input.IsKeyPressed(Key.W)) {
			Position += new Vector2(0, -speed); 
		}
		if (Input.IsKeyPressed(Key.S)) {
			Position += new Vector2(0, speed); 
		}
	}
	public void CheckCollision() {
	//	if ()
	}
}
