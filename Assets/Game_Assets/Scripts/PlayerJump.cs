using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public GameObject player;
    public GameObject cameraTransform;
    private GameObject gameController;

    private float playerHeight;
    private float currentHeight;
    private float previousHeight = 0;
    private float calculatedForce;

    private CharacterController character;


    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.Find("GameController");
        character = player.GetComponent<CharacterController>();
        Debug.Log("Hit the start function");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Got in the Update function");
        gameController = GameObject.Find("GameController");
        playerHeight = gameController.GetComponent<PlayerHeight>().avgHeight;
        currentHeight = cameraTransform.transform.position.y;

        if (currentHeight > playerHeight)
        {
            Debug.Log("Success into first Loop");
            calculatedForce = currentHeight - playerHeight;
            previousHeight = currentHeight;
            currentHeight = cameraTransform.transform.position.y;

                Debug.Log("Nailed it!");
                Vector3 forwardMovement = cameraTransform.transform.forward * calculatedForce;
                //character.Move(forwardMovement * calculatedForce);
        }
    }
}
