using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomTraits : MonoBehaviour
{
    public bool MushGrabbed = false;

    // Start is called before the first frame update
    void Start()
    {
        MushGrabbed = false;
    }

    // Update is called once per frame
    public void PickedUpMushroom()
    {
        MushGrabbed = true;
    }
}
