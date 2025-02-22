using Godot;
using System;
using Hideaway.Entities;
using Hideaway.Events;

public partial class Player : CharacterBody2D, IEntity, IWalkable
{
    [Export]
    public double Speed { get; set; } = 100;
	public bool isWalking { get; set;}

    bool IWalkable.IsWalking { get => IsWalking; set => throw new NotImplementedException(); }
    public AnimationPlayer Anim { get; set; }
    public Sprite2D Sprite { get; set; }

    public override void _Ready()
    {
        this.Initialize();
    }

	public bool IsWalking
	{
		get { return isWalking; }
	}




    // Called every frame. 

    public void Walk(double distance, Vector2 direction)
	{

        if (this.IsWalking){

            GetWalkAnimation(direction);

            Anim.Play("walk");
        }

        else{

            isWalking = true;
            
            // alert the event bus that the player is walking
            // TODO: Implement event bus
            WalkStart walkStart = new WalkStart(this);

            //GD.Print($"Walking {distance} units");
        }


        this.Velocity = direction * (Single)this.Speed;

		// Implement walking logic here
		isWalking = true;
		

        MoveAndSlide();
	}

	public void Stop()
	{

		// Implement stop logic here
		

        if (this.IsWalking){
            isWalking = false;
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


    }

    public void Update(double delta)
    {

		Vector2 direction = Input.GetVector("walkLeft", "walkRight", "walkUp", "walkDown");

        if (!Input.IsActionPressed("walkLeft") || !Input.IsActionPressed("walkRight") || !Input.IsActionPressed("walkUp") || !Input.IsActionPressed("walkDown")){
            this.Stop();
        }

        this.Walk(1, direction);

        
    }

    public void Destroy()
    {
        QueueFree();
    }

    public override void _PhysicsProcess(double delta){


        this.Update(delta);

        
        

    }

    public string GetWalkAnimation(Vector2 direction)
    {

        GD.Print(direction);

        return "";
    }

}
