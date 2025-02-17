using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : PlayerState
{
    public PlayerJumpState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Player.SetVelocity(xInput * Player.moveSpeed, Player.jumpForce);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        Player.SetVelocity(xInput * Player.moveSpeed, rb.velocity.y);

        if (rb.velocity.y < 0)
        {
            stateMachine.ChangeState(Player.airState);
        }
        
    }
}
