using Godot;
using System;

public partial class Hud : CanvasLayer{

    Label StageName; // the name of the current stage, passed from the parent scene
    AnimationPlayer AnimationPlayer; // the animation player used to play scene transitions
    ColorRect TransitionLayer; // the transition layer itself

    public override void _Ready(){
        
        // Get the nodes
        StageName = GetNode<Label>("StageName");
        AnimationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
        TransitionLayer = GetNode<ColorRect>("TransitionLayer");

    }

    // try to play simple scene transitions
    public void PlaySceneTransition(string transition) {

        // set ui items visible
        TransitionLayer.Visible = true;
        StageName.Visible = true;

        // simply call the animation player for now
        AnimationPlayer.Play(transition);

    }

    // used to ensure that the UI is invisible during events like cutscenes
    public void HideUI() {
    
        // set ui items invisible
        TransitionLayer.Visible = false;
        StageName.Visible = false;
    }




}
