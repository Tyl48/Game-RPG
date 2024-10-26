using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeMoveState : EnemyState
{
    private EnemySkeleton enemy;
    public SkeMoveState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBoolName, EnemySkeleton _enemy) 
        : base(_enemyBase, _stateMachine, _animBoolName)
    {
        this.enemy = _enemy;
    }

    public override void Enter()
    {
        base.Enter();
    }


    public override void Update()
    {
        base.Update();
        enemy.SetVelocity(enemy.moveSpeed*enemy.facingDir, enemy.rb.velocity.y);

        if (enemy.isWallDetected() || !enemy.isGroundDetected())
        {
            enemy.Flip();
            stateMachine.ChangeState(enemy.idleState);
        }
    }
    public override void Exit()
    {
        base.Exit();
    }
}