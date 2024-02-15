using Godot;
using System;
using System.Drawing;

public partial class Movement : CharacterBody2D
{
	[Export] private int speed;
	KinematicCollision2D Collision2D;
	TileMap tileMap;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GetChild<AnimatedSprite2D>(2).Play();
		tileMap = GetNode<TileMap>("Tilemap");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		AddVelocity();
		Collision2D = MoveAndCollide(Velocity);
		CheckCollision();
	}

	public void AddVelocity() {
		Velocity = new Vector2(0,0);
		if (Input.IsKeyPressed(Key.D)) {
			 
			Velocity += new Vector2(speed, 0); 
			if (!Input.IsKeyPressed(Key.Shift)) {
				GetChild<AnimatedSprite2D>(2).Scale = new Vector2(2, 2);
			}
		}
		if (Input.IsKeyPressed(Key.A)) {
			Velocity += new Vector2(-speed, 0);
			if (!Input.IsKeyPressed(Key.Shift)) {
				GetChild<AnimatedSprite2D>(2).Scale = new Vector2(-2, 2);
			}
		}
		if (Input.IsKeyPressed(Key.W)) {
			Velocity += new Vector2(0, -speed); 
		}
		if (Input.IsKeyPressed(Key.S)) {
			Velocity += new Vector2(0, speed); 
		}
	}
	public void CheckCollision() {
		GodotObject collider = Collision2D.GetCollider();
		if (collider.GetType() == TileMap) {
			
		}
		
	}
}
