using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoundBabyMushroom : MonoBehaviour
{
    public bool BabyMushGrabbed = false;

    // Update is called once per frame
    public void PickedUpMushroom()
    {
        BabyMushGrabbed = true;
    }


    //For data Collection
    public bool MushyState()
    {
        bool BabyMush = BabyMushGrabbed;
        return BabyMush;
    }
}
