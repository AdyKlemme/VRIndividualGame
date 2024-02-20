using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpeechAppear : MonoBehaviour
{

    public GameObject player;
    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Main Camera");
        NPC1 = GameObject.Find("NPC1Plane");
        NPC2 = GameObject.Find("NPC2Plane");
        NPC3 = GameObject.Find("NPC3Plane");

        NPC1.SetActive(false);
        NPC2.SetActive(false);
        NPC3.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        float distNPC1 = Vector3.Distance(NPC1.transform.position, player.transform.position);
        float distNPC2 = Vector3.Distance(NPC2.transform.position, player.transform.position);
        float distNPC3 = Vector3.Distance(NPC3.transform.position, player.transform.position);


        //NPC1
        if (distNPC1 < 5f)
        {
            NPC1.SetActive(true);
        }
        if (distNPC1 > 5f)
        {
            NPC1.SetActive(false);
        }


        //NPC2
        if (distNPC2 < 5f)
        {
            NPC2.SetActive(true);
        }

        if (distNPC2 > 5f)
        {
            NPC2.SetActive(false);
        }

        //NPC3
        if (distNPC3 < 5f)
        {
            NPC3.SetActive(true);
        }

        if (distNPC3 > 5f)
        {
            NPC3.SetActive(false);
        }

    }
}
