using Godot;
using System;

public partial class PlayerCamera : Camera2D
{

	enum MODE {FOLLOW_PLAYER, FOCUS_ON_POINT}

	[Export] MODE currentMode = MODE.FOLLOW_PLAYER;

	public Vector2 TargetPosition {get; set;}

    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);

		switch (currentMode)
		{
			
			case MODE.FOLLOW_PLAYER: 
				break;
			case MODE.FOCUS_ON_POINT:
				break;
		}
    }


	

}
