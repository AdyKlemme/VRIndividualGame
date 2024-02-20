using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class SwordHit : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {

        //hitName = collision.gameObject;

        if (collision.gameObject.CompareTag("Staff"))
        {
            //Destroy(gameObject);
            GetComponent<EnemyStats>().TakeDamage(1);
            //Debug.Log("hit");
        }
            
    }


}
