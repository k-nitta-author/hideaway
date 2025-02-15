using System;
using Godot;

namespace Hideaway.Entities
{
    public interface IWalkable
    {
        double Speed {get; set;}

        void Walk(double distance, Vector2 direction);
        void Stop();
        bool IsWalking { get; set;}
    }
}