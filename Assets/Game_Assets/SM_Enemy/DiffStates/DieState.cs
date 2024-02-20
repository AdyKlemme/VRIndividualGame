using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieState : EnemyState
{
    public DieState(EnemySM esc) : base(esc) { }

    private EnemyStats stats;
    public int kills;


    public override void OnStateEnter()// Kinda like Start
    {
        stats = esc.enemy.GetComponent<EnemyStats>();
        kills = esc.gameController.GetComponent<EnemySpawner>().Kills;
    }
    public override void CheckTransitions() //Possible transitions from this state
    {

    }
    public override void Act()
    {
        if (stats.EnemyHealth <= 0)
        {
            if(kills < 7)
            {
                esc.gameController.GetComponent<EnemySpawner>().Spawn();

            }
            esc.gameController.GetComponent<EnemySpawner>().KillCount();
            esc.DestroyEnemy();
        }

    }
    public override void OnStateExit() 
    {
    }
}
