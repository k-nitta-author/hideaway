using Godot;
using Hideaway;
using Hideaway.Events;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial class Stage : Node2D, IEventSubscriber
{

	private AnimationPlayer anim;
	private Hud hud;

	public Map CurrentMap;

	public Player player;

	/// <summary>
	/// Called when the node enters the scene tree for the first time.
	/// </summary>
	public override void _Ready()
	{
		// initialize child nodes
		anim = GetNode<AnimationPlayer>("AnimationPlayer"); // used to animate stage behaviors like scene transitions, etc.
		hud = GetNode<Hud>("hud");

		// the default map of the main scene
		CurrentMap = GetNode<Map>("Map");
		

		// Implement logic to start the stage
		PlayStageIntro();
	}

	public override void _Process(double delta)
	{
	}

	public Stage Setup(Game game)
	{
		return this;
	}

	public Stage WithPlayerAt(Vector2 position)
	{
		player.GlobalPosition = position;

		return this;
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

    public void SubscribeTo(IEventPublisher publisher)
    {
        throw new NotImplementedException();
    }

    public void UnsubscribeFrom(IEventPublisher publisher)
    {
        throw new NotImplementedException();
    }

}
