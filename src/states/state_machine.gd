# the base state machine class 
class_name StateMachine
extends Node

var is_active := true: set = set_is_active # when true the physics process will run and it will run
var current_state : BaseState =  NullState.new() # the current state variable used each physics process

# setter for the is_active variable
func set_is_active(value: bool) -> void:
    is_active = value
    set_physics_process(value)

# the physisc process function
func _physics_process(_delta: float) -> void: current_state.update()
