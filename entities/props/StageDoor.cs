using Godot;
using System;
using Hideaway.Events;
using Hideaway.Entities;

public partial class StageDoor : Area2D, IEventBusPublisher, IEntity
{

	private Stage CurrentStage;

	[Export]
	string nextStage { get; set;}

	string egressName {get; set;}

    public AnimationPlayer Anim { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Sprite2D Sprite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
		// Get the current stage
		CurrentStage = GetParent<Stage>();

		Initialize();
	}

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);
		
		Update(delta);

    }

    public void _on_StageDoor_body_entered(Node body)
	{

		GD.Print("StageDoor body entered");

		

		// Check if the body is a Player instance
		if (!(body is Player))
		{
			return;
		}

		CheckBeforeExitStage((Player)body);

		// play this animation when the player exits scene
		this.Anim.Play("exit");

		// publish the exit stage event

		ExitStage e = new ExitStage(CurrentStage.Name, this, CurrentStage.Name, nextStage); 

		//Publish(e);

		CurrentStage.HandleExitStage(e);
	}

	public bool CheckBeforeExitStage(Player player)
	{
		return false;

	}

    public void Publish(IEvent e)
    {
        throw new NotImplementedException();
    }

    public void Initialize()
    {
        this.Anim = GetNode<AnimationPlayer>("AnimationPlayer");
        this.Sprite = GetNode<Sprite2D>("Sprite2D");
    }

    public void Update(double delta)
    {
        throw new NotImplementedException();
    }

    public void Destroy()
    {
        throw new NotImplementedException();
    }
}
