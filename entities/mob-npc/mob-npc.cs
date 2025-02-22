using System;
using System.Runtime.CompilerServices;
using Godot;
using Hideaway.Entities;
using Hideway.Events;

namespace Hideway.Entities
{
    public partial class MobNpc : CharacterBody2D, IEntity, IWalkable, ITalkable
    {
        public double Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsWalking { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public AnimationPlayer Anim { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Sprite2D Sprite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Destroy()
        {            
            // triggers a DespawnEvent for the current object and then frees the object from memory
            DespawnEvent despawn = new DespawnEvent(this); 

            QueueFree();
        }

        public string GetWalkAnimation(Vector2 direction)
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {

            this.Anim = GetNode<AnimationPlayer>("AnimationPlayer");
            this.Sprite = GetNode<Sprite2D>("Sprite");


            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Talk(string dialogue)
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