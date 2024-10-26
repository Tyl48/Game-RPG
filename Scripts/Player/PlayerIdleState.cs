using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerGroundedState
{
    public PlayerIdleState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Player.ZeroVelocity();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if (xInput == Player.facingDir && Player.isWallDetected()) 
        { 
            return; 
        }
        if (xInput != 0 && !Player.isBusy) 
        { 
            stateMachine.ChangeState(Player.moveState); 
        }
    }
}
