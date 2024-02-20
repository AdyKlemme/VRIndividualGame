using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class StartColl : MonoBehaviour
{
    public bool isMushroomHeld;
    private bool okayToGrabMushroom;

    void Start()
    {
        isMushroomHeld = false;
        okayToGrabMushroom = true;
    }





    public void GrabStart()
    {
        SceneManager.LoadScene("GameLoop1");
    }
    public void GrabCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void GrabQuit()
    {
        Application.Quit();
    }





    // aaron's maybe code
    public void MushroomPickedUp()
    {
        if (okayToGrabMushroom)
        {
            isMushroomHeld = true;
            okayToGrabMushroom = false;
        }
    }

    public void DropMushroom()
    {
        if (!okayToGrabMushroom)
        {
            isMushroomHeld = false;
            okayToGrabMushroom = true;
        }
    }

}
