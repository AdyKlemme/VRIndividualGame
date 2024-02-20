using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemySM : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject gameController;
    public EnemyState currentState;


    //States movement speeds
    public float enemyWander = 1f;
    public float enemyChase = 2f;


    //WanderState movement
    [SerializeField] private List<Transform> movePositions = new List<Transform>();
    public NavMeshAgent a_Agent;
    public Transform CurrentDestination;

    public Transform playerTransform;



    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController");
        player = GameObject.Find("Complete XR Origin Set Up Variant");
        playerTransform = GameObject.Find("Complete XR Origin Set Up Variant").transform;

        movePositions.Add(GameObject.Find("Dest1").transform);
        movePositions.Add(GameObject.Find("Dest2").transform);
        movePositions.Add(GameObject.Find("Dest3").transform);
        movePositions.Add(GameObject.Find("Dest4").transform);
        //movePositions.Add(GameObject.Find("Main Camera").transform); <_Complete XR
        Debug.Log(movePositions.Count);

        SetState(new WanderState(this));

        a_Agent = enemy.GetComponent<NavMeshAgent>();
        CurrentDestination = RandomDestination();

    }

    void Update()
    {

        currentState.CheckTransitions();
        currentState.Act();

        playerTransform = GameObject.Find("Complete XR Origin Set Up Variant").transform;
    }

    public void SetState(EnemyState es)
    {
        if (currentState !=null)
        {
            currentState.OnStateExit();
        }

        currentState = es;

        if(currentState != null)
        {
            currentState.OnStateEnter();
        }
    }

    public void DestroyEnemy()
    {
        Destroy(enemy);
    }

     public Transform RandomDestination()
    {
        if (movePositions.Count > 0)
        {
            int rd = UnityEngine.Random.Range(0, movePositions.Count-1);
            // Debug.Log("1");
            return movePositions[rd];
        }
        //Debug.Log("2");
        return movePositions[1];
    }



}
