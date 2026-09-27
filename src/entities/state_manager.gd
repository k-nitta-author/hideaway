class_name StateManager
extends Node

var current_state : BaseState: set = set_current_state

signal state_changed()

func set_current_state(value: BaseState) -> void:
    
    var old_state: BaseState = current_state
    current_state = value

    old_state.exit_state()

    current_state.enter_state(old_state, current_state)

    emit_signal("state_changed")

func update() -> void: pass
    