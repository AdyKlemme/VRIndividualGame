using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyState
{
    protected EnemySM esc;
    
    public abstract void CheckTransitions();
    public abstract void Act();
    public virtual void OnStateEnter() { }
    public virtual void OnStateExit() { }

    public EnemyState(EnemySM esc) 
    {
        this.esc = esc;
    }

}

//public WanderState(EnemySM esc) : base(esc) { }
//
//public override void OnStateEnter()
//{

//}
//public override void CheckTransitions()
//{

//}
//public override void Act()
//{

//}
//public override void OnStateExit() { }
