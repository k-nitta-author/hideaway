using Godot;

// an area that the player may interact with 
public partial class TriggerArea : Area2D
{
	[Export] bool isAutoInteractible; // if true; do not wait for interact

	[Export] bool isActive {get {return _isActive;} set {SetIsActive(value);}} // if true it is able to trigger
	bool _isActive = true;

	bool isPlayerInArea;

    public override void _Ready()
    {
		// connect relevant signals
        AreaEntered += OnAreaEntered;
		AreaExited += OnAreaExited; 
    }

	// the setter for is active
	void SetIsActive(bool value)
	{
		_isActive = value;

		// set the area's monitoring off
		SetDeferred("monitoring", value);
	}

	// called whenever a relevant area is entered
	public void OnAreaEntered(Area2D area)
	{
		isPlayerInArea = true;

		// do something if auto interactible
		if (isAutoInteractible)
		{
			Trigger();	
		}
	}

	// called whenever a relevant area is exited
	public void OnAreaExited(Area2D area)
	{
		isPlayerInArea = false;
	}

    public override void _UnhandledInput(InputEvent @event)
    {
        if (@event.IsActionPressed("Interact"))
		{
			Trigger();
		}
    }



	// called to trigger nodes
	public virtual void Trigger()
	{
		
	}

}
