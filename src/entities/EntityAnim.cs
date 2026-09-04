using Godot;
using Hideaway.Entities;
using System;
using System.Collections.Generic;

public partial class EntityAnim : AnimationPlayer
{

	IEntity entity {get; set;}

    public override void _Ready()
    {
        base._Ready();

		this.entity = GetParent<IEntity>();
			
    }

    // Orient Entity's Features as Needed
    // Because most characters in HideWay are Humanoid
    // the system currently needs no support for non-humanoid features
    public void OrientEntity(Vector2 direction)
	{

	}

	// play the walking animation with added parameters
	public void PlayWalk(Vector2 direction)
	{

		var directions = new Dictionary<double, string> {{0, "up"}, {1.570796, "right"}, {3.141593, "down"}, {4.712389, "left"}};

		float Angle = direction.Angle();

		this.Play("walk_" + directions[(double)Angle]);
	}

}
