using Godot;
using Hideaway.Events;
using System;

public partial class Stage : Node2D
{


	private AnimationPlayer anim;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// initialize child nodes
		anim = GetNode<AnimationPlayer>("AnimationPlayer"); // used to animate stage behaviors like scene transitions, etc.
		

		// Implement logic to start the stage
		PlayStageIntro();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);
    }


    // Called when the node receives an input event.
    // currently meant to instantiate events from /events
    public void _unhandled_input(InputEvent @event)
	{
		if (@event is InputEventKey eventKey)
		{

			GD.Print("Key pressed: ");

		}
	}


	public void PlayStageIntro(){
		// Implement logic to play the stage intro

	}
	
	// This method is called when the player enters a stage door
	public void HandleExitStage(ExitStage e)
	{

		GD.Print(e.NextStage);

		if (e.Name == null || e.Name == "")
		{
			GD.Print("Stage name is null");
			return;
		}


		// Implement logic to leave the stage
		GetTree().ChangeSceneToFile("res://stages/" + e.NextStage + ".tscn");
	}
}
