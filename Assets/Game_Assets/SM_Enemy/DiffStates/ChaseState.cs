using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : EnemyState
{
    public ChaseState(EnemySM esc) : base(esc) { }

    private EnemyStats stats;
    private bool isMushroomGrabbed;

    
    public override void OnStateEnter()
    {
        stats = esc.enemy.GetComponent<EnemyStats>();
        esc.enemy.GetComponent<Renderer>().material.color = new Color(1f, 1f, 0f);
        

    }
    public override void CheckTransitions()
    {
        isMushroomGrabbed = esc.gameController.GetComponent<FoundMushroom>().MushGrabbed;
        float dist = Vector3.Distance(esc.transform.position, esc.player.transform.position);
        if (dist > 10f && !isMushroomGrabbed)/*&& !isMushroomGrabbed)*/
        {
            esc.SetState(new WanderState(esc));
        }


        if (stats.EnemyHealth < 5)
        {
            esc.SetState(new FleeState(esc));
        }

        if (stats.EnemyHealth <= 0)
        {
            esc.SetState(new DieState(esc));
        }

        //if (dist < 5f && isMushroomGrabbed == true)
        //{
        //    esc.SetState(new AttackState(esc));
        //}


    }
    public override void Act()
    {
        esc.a_Agent.SetDestination(esc.playerTransform.position);
        //esc.enemy.transform.position = Vector3.MoveTowards(esc.enemy.transform.position, esc.player.transform.position, esc.enemyChase * Time.deltaTime);
    }


    public override void OnStateExit() 
    {
    }
}
