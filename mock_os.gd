extends Control

@onready var startButton: Button = $startButton
@onready var appIconsControl: Control = $appIconsControl

func _ready() -> void:
    startButton.connect("pressed", on_start_pressed)

func display_start_menu() -> void:
    pass

func on_start_pressed() -> void:
    display_start_menu()