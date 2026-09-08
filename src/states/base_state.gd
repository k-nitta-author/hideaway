class_name BaseState
extends RefCounted

# called when player enters state
func enter() -> void: pass

# called when player exits state
func exit() -> void: pass

# called every tick by the state_machine
func update() -> void: pass


