using System;
using Godot;

namespace Hideaway.Entities
{
    public interface IWalkable
    {
        double Speed {get; set;}

        void Walk(double distance, Vector2 direction); // walk in the given direction
        
        string GetWalkAnimation(Vector2 direction); // Gets the walk animation based on the direction.

        void Stop();
        bool IsWalking { get; set;}
    }
}