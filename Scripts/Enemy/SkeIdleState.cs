using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeIdleState : EnemyState
{
    EnemySkeleton enemy;
    public SkeIdleState(Enemy _enemyBase, EnemyStateMachine _stateMachine, string _animBoolName, EnemySkeleton _enemy) : base(_enemy, _stateMachine, _animBoolName)
    {
        enemy = _enemy;
    }

    public override void Enter()
    {
        base.Enter();
        stateTimer = enemy.idleTime;

    }


    public override void Update()
    {
        base.Update();

        if (stateTimer < 0)
        {
            stateMachine.ChangeState(enemy.moveState);
        }
    }
    public override void Exit()
    {
        base.Exit();
    }
}
