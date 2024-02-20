using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    [SerializeField] private List<Transform> movePositions = new List<Transform>();
    private NavMeshAgent a_Agent;
    private Transform CurrentDestination;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("YAY");
        a_Agent = GetComponent<NavMeshAgent>();
        CurrentDestination = RandomDestination();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, CurrentDestination.position);
        if (dist < 5f)
        {
            CurrentDestination = RandomDestination();
        }

        a_Agent.destination = CurrentDestination.position;

    }

    private Transform RandomDestination()
    {
        if (movePositions.Count > 0)
        {
            int rd = UnityEngine.Random.Range(0, movePositions.Count-1); //movePositions.Count where 4 is
            return movePositions[rd];
        }
        return null;
    }

}
