using Godot;
using System;
using Hideaway.Entities;

public partial class Player : CharacterBody2D, IEntity, IWalkable
{
	
    public double Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double PositionX { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double PositionY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	private bool isWalking;

	public bool IsWalking
	{
		get { return isWalking; }
	}

    public void Walk(float distance)
	{
		// Implement walking logic here
		isWalking = true;
		GD.Print($"Walking {distance} units");
	}

	public void Stop()
	{
		// Implement stop logic here
		isWalking = false;
		GD.Print("Stopped walking");
	}

    public void Initialize()
    {
        throw new NotImplementedException();
    }

    public void Update(float delta)
    {
        throw new NotImplementedException();
    }

    public void Destroy()
    {
        throw new NotImplementedException();
    }

}
