class_name ActorStateManager
extends StateManager

enum STATE {IDLE, WALK, TALK, JUMP}

var idleState : IdleState = IdleState.new()
var walkState : WalkState = WalkState.new()
var talkState : TalkState = TalkState.new()
var jumpState : JumpState = JumpState.new()

func try_to_change_state(new_state: STATE) -> void:
    match new_state:
        STATE.IDLE:
            current_state = idleState
        STATE.WALK:
            current_state = walkState
        STATE.TALK:
            current_state = talkState
        STATE.JUMP:
            current_state = jumpState