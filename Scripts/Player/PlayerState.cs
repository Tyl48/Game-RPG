using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PlayerState 
{
    protected PlayerStateMachine stateMachine;
    protected Animator anim;
    protected Rigidbody2D rb;
    protected Player Player;
    protected float xInput;
    protected float yInput;
    protected float stateTimer;
    protected bool triggerCalled;
    private string animBoolName;

    public PlayerState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName)
    {
        this.Player = _player;
        this.stateMachine = _stateMachine;
        this.animBoolName = _animBoolName;
    }

    public virtual void Enter()
    {
        Player.anim.SetBool(animBoolName, true);
        rb = Player.rb;
        triggerCalled = false;
    }
    public virtual void Update()
    {
        stateTimer -= Time.deltaTime;
        xInput = Input.GetAxisRaw("Horizontal");
        Player.anim.SetFloat("yVelocity", rb.velocity.y);
    }
    public virtual void Exit() 
    {
        Player.anim.SetBool(animBoolName, false); 
    }

    public virtual void AnimFinishTrigger()
    {
        triggerCalled = true;
    }
}
