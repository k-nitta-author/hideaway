using Godot;
using System;


// This class is a partial class of the PauseMenu node
public partial class PauseMenu : Panel
{

	BaseButton ResumeButton; // Button to resume the game
	BaseButton SettingButton; // Button to open the settings menu
	BaseButton MenuButton; // Button to return to the main menu
	BaseButton QuitButton; // Button to quit the game

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.Visible = false;

		// initialize child nodes
		ResumeButton = GetNode<BaseButton>("VBoxContainer/ResumeButton");
		SettingButton = GetNode<BaseButton>("VBoxContainer/SettingButton");
		MenuButton = GetNode<BaseButton>("VBoxContainer/MenuButton");
		QuitButton = GetNode<BaseButton>("VBoxContainer/QuitButton");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
