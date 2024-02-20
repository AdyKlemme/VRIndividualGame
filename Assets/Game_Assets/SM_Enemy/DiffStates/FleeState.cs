using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeState : EnemyState
{
    public FleeState(EnemySM esc) : base(esc) { }

    private EnemyStats stats;
    private bool isMushroomGrabbed;


    public override void OnStateEnter()// Kinda like Start
    {
        stats = esc.enemy.GetComponent<EnemyStats>();
        isMushroomGrabbed = esc.gameController.GetComponent<FoundMushroom>().MushGrabbed;
    }
    public override void CheckTransitions() //Possible transitions from this state
    {
        float dist = Vector3.Distance(esc.transform.position, esc.player.transform.position);
        if (dist > 20f )
        {
            esc.SetState(new WanderState(esc));
        }
        if (stats.EnemyHealth <= 0)
        {
            esc.SetState(new DieState(esc));
        }
    }
    public override void Act()
    {
        Vector3 directionAwayPlayer = esc.player.transform.position + esc.enemy.transform.position;
        esc.enemy.transform.Translate(directionAwayPlayer.normalized * esc.enemyWander * Time.deltaTime);

        if (stats.EnemyHealth <= 0)
        {
            esc.enemy.GetComponent<EnemySpawner>().Spawn();
            esc.DestroyEnemy();
        }

    }
    public override void OnStateExit()
    {
    }
}
