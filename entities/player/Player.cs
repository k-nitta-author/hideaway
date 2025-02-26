using Godot;
using System;
using Hideaway.Entities;
using Hideaway.Events;
using System.Collections.Generic;
using Godot.Collections;
using Hideaway;
using System.Linq;
using Hideway.Events;

public partial class Player : CharacterBody2D, IEntity, IWalkable, IInteractor, IEventPublisher
{
    [Export]
    public double Speed { get; set; } = 100;
    [Export]
    public bool IsWalking { get; set; }
    public AnimationPlayer Anim { get; set; }

    [Export]
    public bool CanInteract { get; set; }

    public Sprite2D Body { get; set; }
    public Sprite2D Head { get; set; }
    public Sprite2D Sprite{ get; set; }
    public Area2D InteractBox {get; set;}


    public IEventSubscriber[] Subscribers { get; set; }


    //public Sprite2D Accessory { get; set; }

    public override void _Ready()
    {
        this.Initialize();
    }

    // Called every frame. 
    public void Walk(double distance, Vector2 direction)
	{

        if (this.IsWalking){

            return;
        }

        else{
            
            // alert the event bus that the player is walking
            // TODO: Implement event bus
            WalkStart walkStart = new WalkStart(this);

            //GD.Print($"Walking {distance} units");
        }
        
        Anim.Play(GetWalkAnimation(direction));

        this.OrientFeatures(this.Head, direction);

        this.Velocity = direction * (Single)this.Speed;

		// Implement walking logic here
		IsWalking = true;
		

        MoveAndSlide();
	}

	public void Stop()
	{

		// Implement stop logic here
		
        if (this.IsWalking){
            IsWalking = false;
        }

        else{            
            
            // alert the event bus that the player is walking
            // TODO: Implement event bus
            //WalkStart walkStart = new WalkStart(this);
            return;

        }
		
	}

    public void Initialize()
    {
        GD.Print("Player initialized");
        
        this.Anim = GetNode<AnimationPlayer>("AnimationPlayer");
        this.Sprite = GetNode<Sprite2D>("Sprite");
        this.Head = GetNode<Sprite2D>("Head");
        this.Body = GetNode<Sprite2D>("Body");

        this.InteractBox = GetNode<Area2D>("InteractBox");
    }

    public void Update(double delta)
    {

        // interaction controls

        if (Input.IsActionJustPressed("Interact"))
        {
            this.QueryInteraction();
        }

        // the walk controls

		Vector2 direction = Input.GetVector("walkLeft", "walkRight", "walkUp", "walkDown");

        this.Walk(1, direction);

        if (!Input.IsActionPressed("walkLeft") || !Input.IsActionPressed("walkRight") || !Input.IsActionPressed("walkUp") || !Input.IsActionPressed("walkDown")){
            this.Stop();
        }
    }

    // Call this when 
    public void Destroy()
    {

        // create new despawn event for despawn
        DespawnEvent e = new DespawnEvent(this, "despawn");

        // wait to implement this
        //this.Publish(e);

        QueueFree(); // free resources
    }

    public override void _PhysicsProcess(double delta){

        this.Update(delta);

    }

    // select the correct walking animation for the entity
    public string GetWalkAnimation(Vector2 direction)
    {

        var sideways = new Godot.Collections.Dictionary<int, string> { { -1, "left" }, { 1, "right" } };

        if (Mathf.Abs(direction.X) > 0)
        {
            return "walk_" + sideways[(int)Math.Round(direction.X)];
        }

        else if(Mathf.Abs(direction.Y) > 0)
        {
            return "walk_up";
        }

        else
        {
            return "idle";
        }

    }

    // get all physical features to face the correct directions
    public void OrientFeatures(Sprite2D Head,Vector2 direction)
    {

        Head.FlipH = (direction.X > 0);
    }

    public void Interact(IInteractible interactible)
    {

        if (!interactible.Interactible)
        {
            return;
        }

        InteractionEvent e = new InteractionEvent(interactible, "interaction");

    }

    public void QueryInteraction()
    {

        // 
        bool NumberOfBodies = InteractBox.GetOverlappingBodies().Count == 0;

        this.CanInteract = NumberOfBodies;
    }

    public void Publish(IEvent e)
    {
        for (int i = 0; i < this.Subscribers.Count(); i++)
        {
            //this.Subscribers[i]
        }
    }

    // return whehter there are subs
    public bool HasSubscribers()
    {
        return !(Subscribers.Count() == 0);
    }
}
