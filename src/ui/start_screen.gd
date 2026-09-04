extends Control

@onready 
var anim = $AnimationPlayer

# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass


# quet the game on click
func _on_quit_pressed():
	# TODO: implement functionality for the animation player
	get_tree().quit() 

# navigate to the main stage in the game
func _on_start_game_pressed():

	# TODO: modify the scene 
	# change current scene to main stage
	get_tree().change_scene_to_file("res://stages/main.tscn") 
