using System;
using Godot;
using Hideaway.Entities;

namespace Hideway.Entities
{
    public partial class MobNpc : CharacterBody2D, IEntity, IWalkable
    {
        public double Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsWalking { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Update(double delta)
        {
            throw new NotImplementedException();
        }

        public void Walk(double distance, Vector2 direction)
        {
            throw new NotImplementedException();
        }
    }

}