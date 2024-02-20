using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class AttackState : EnemyState
{
    public AttackState(EnemySM esc) : base(esc) { }

    [SerializeField] private GameObject Enemy;
    private EnemyStats stats;


    public override void OnStateEnter() 
    {
        stats = Enemy.GetComponent<EnemyStats>();
    }
    public override void CheckTransitions()
    {

    }
    public override void Act()
    {

    }
    public override void OnStateExit() { }
}
