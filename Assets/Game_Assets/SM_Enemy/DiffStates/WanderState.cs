using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WanderState : EnemyState
{

    public WanderState(EnemySM esc) : base(esc) { }

    private EnemyStats stats;
    private EnemySM a_Agent;

    private bool isMushroomGrabbed;


    public override void OnStateEnter()
    {
        stats = esc.enemy.GetComponent<EnemyStats>();


    }


    public override void CheckTransitions()
    {
        isMushroomGrabbed = esc.gameController.GetComponent<FoundMushroom>().MushGrabbed;
        float dist = Vector3.Distance(esc.transform.position, esc.player.transform.position);
        
        if (isMushroomGrabbed == true) 
        {
            esc.SetState(new ChaseState(esc));
        }

        if (stats.EnemyHealth <= 5)
        {
            esc.SetState(new FleeState(esc));
        }

        if (stats.EnemyHealth <= 0)
        {
            esc.SetState(new DieState(esc));
        }
    }
    public override void Act()
    {
        float dist = Vector3.Distance(esc.transform.position, esc.CurrentDestination.position);
        if (dist < 1.2f)
        {
            esc.CurrentDestination = esc.RandomDestination();
        }

        esc.a_Agent.destination = esc.CurrentDestination.position;

    }
    public override void OnStateExit() 
    {
    
    }
}
