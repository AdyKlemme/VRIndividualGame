using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoundMushroom : MonoBehaviour
{
    public bool MushGrabbed = false;

    public void Start()
    {
        Debug.Log("Started");
    }
    // Update is called once per frame
    public void PickedUpMushroom()
    {
        Debug.Log("Found");
        MushGrabbed = true;
    }


    //For data Collection
    public bool MushyState()
    {
        bool Mush = MushGrabbed;
        return Mush;
    }
}
