using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeight : MonoBehaviour
{
    public GameObject cameraTransform;
    public GameObject[] objectsToDestroy; // List of objects to destroy

    public float playerHeight1 = 0;
    public float playerHeight2 = 0;
    public float playerHeight3 = 0;
    public float avgHeight = 0;
    public float constHeight = 0;

    public float playerHeight11 = 0;
    public float playerHeight22 = 0;
    public float playerHeight33 = 0;

    private float delayTimer = 1.0f; // The delay time in seconds
    private float currentTime = 0.0f;
    private bool isWaiting = false;


    private void Update()
    {
        constHeight = cameraTransform.transform.position.y;
        if (isWaiting)
        {
            currentTime += Time.deltaTime; // Increment the timer.
            if (currentTime >= delayTimer)
            {
                // Time has passed, continue with your code here.
                currentTime = 0.0f; // Reset the timer for future use.
                isWaiting = false;
            }
        }
    }

    public void StartWaiting()
    {
        isWaiting = true;
    }

    public void CalculateHeight()
    {

        // Get the player's height by accessing the y position of the camera
        playerHeight1 = cameraTransform.transform.position.y;
        StartWaiting();
        playerHeight2 = cameraTransform.transform.position.y;
        StartWaiting();
        playerHeight3 = cameraTransform.transform.position.y;
        StartWaiting();
        avgHeight = (playerHeight1 + playerHeight2 + playerHeight3) / 3;



    }

    public void DestroyObjects() 
    {
        StartWaiting();
        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj);
        }
    }

    public float WriteHeight1()
    {
        float playerHeight11 = playerHeight1;
        return playerHeight11;
    }
    public float WriteHeight2()
    {
        float playerHeight22 = playerHeight2;
        return playerHeight22;
    }
    public float WriteHeight3()
    {
        float playerHeight33 = playerHeight3;
        return playerHeight33;
    }
    public float WriteAvgHeight()
    {
        float playerAvgHeight = avgHeight;
        return playerAvgHeight;
    }
}

