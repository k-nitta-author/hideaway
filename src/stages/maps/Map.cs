using Godot;
using Hideaway;
using Hideaway.Events;
using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

public partial class Map : Node2D, IEventPublisher
{

	[Export]
	private string MapName; 

	// initialize the layers
	private TileMapLayer GroundLayer;
	private TileMapLayer WallLayer;
	private TileMapLayer BuildingLayer;

	// the stage that owns this map
	private Stage _Stage;

	private StageDoor[] EgressPoints;

	// the subscribers of various events
    public IEventSubscriber[] Subscribers { get; set; }

	// Godot Signals


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{

		// initialize the layer
		this.GroundLayer = GetNode<TileMapLayer>("ground");
		this.WallLayer = GetNode<TileMapLayer>("walls");
		this.BuildingLayer = GetNode<TileMapLayer>("buildings");

		// maps are meant to be the direct children of stages
		this._Stage = GetParent<Stage>();

		this._Stage.SubscribeTo(this);

	}

	private void AddToStage(Stage stage)
	{
		// use injected stage and add this to it
		stage.AddChild(this);
		this.Owner = stage;

		// reposition the map to the correct position
		this.Position = stage.CurrentMap.GlobalPosition;
	}

	private void RemoveFromStage(Stage stage)
	{
		// simply remove the node
		stage.RemoveChild(stage.CurrentMap);
		stage.CurrentMap.QueueFree();
		
	}

	// Switch the current map to this map
	public void SwtichMap(Stage stage)
	{
		// remove the previous map from the stage 
		RemoveFromStage(stage);

		// add this map to the stage
		AddToStage(stage);
		stage.CurrentMap = this;



	}


	public void ExitMap()
	{
		//ExitStage exitStage = new ExitStage(this.MapName, this, this._Stage.CurrentStage.Name, this._Stage.NextStage.Name);
	}

    public void Publish(IEvent e)
    {
		// test out the event
		GD.Print(e.Name + "has been published");

		EmitSignal("");
    }

    public bool HasSubscribers()
    {
        throw new NotImplementedException();
    }

    public void RegisterSubscriber(IEventSubscriber subscriber)
    {
        this.Subscribers.Append(subscriber);
				
    }

	public void AddEgress(StageDoor stageDoor)
	{
		this.EgressPoints.Append(stageDoor);
	}

}
