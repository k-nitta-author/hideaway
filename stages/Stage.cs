using Godot;
using Hideaway;
using Hideaway.Events;
using System;
using System.Collections.Generic;

public partial class Stage : Node2D, IEventSubscriber
{


	private AnimationPlayer anim;
	private Hud hud;

	public Map CurrentMap; 

	/// <summary>
	/// Called when the node enters the scene tree for the first time.
	/// </summary>
	public override void _Ready()
	{
		// initialize child nodes
		this.anim = GetNode<AnimationPlayer>("AnimationPlayer"); // used to animate stage behaviors like scene transitions, etc.
		this.hud = GetNode<Hud>("hud");

		// the default map of the main scene
		this.CurrentMap = GetNode<Map>("Map");
		

		// Implement logic to start the stage
		this.PlayStageIntro();
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


		// using branchless coding principles, try to match each input event to an action
		//Dictionary<InputEventKey, Action> keys = new Dictionary<InputEventKey, Action>
		//{
		//	{ null, () => this.PlayStageIntro() },
		//};

		// 
		if (@event is InputEventKey eventKey)
		{

			//GD.Print("Key pressed: ");

			return;

		}
	}


	public void PlayStageIntro(){
		// Implement logic to play the stage intro

	}
	
	// This method is called when the player enters a stage door
	public void HandleExitStage(ExitStage e)
	{

		if (e.Name == null || e.Name == "")
		{
			GD.Print("Stage name is null");
			return;
		}

		string mapFolder = "res://stages/maps/";

		Map NextMap = this.LoadNextMap(mapFolder + e.NextStage + ".tscn");

		GD.Print("Test:" + NextMap.Name);

		NextMap.SwtichMap(this);

		// Implement logic to leave the stage
		//GetTree().ChangeSceneToFile("res://stages/" + e.NextStage + ".tscn");
	}

	private Map LoadNextMap(string NextMapName)
	{
		PackedScene NewMapScene = GD.Load<PackedScene>(NextMapName);

		Map MapInstance = NewMapScene.Instantiate<Map>();

		return MapInstance;
		
	}
}
