using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.XR.OpenVR;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour
{

    public int EnemyHealth = 10;
    public int Kills = 0;

    void Start()
    {
        EnemyHealth = 10;
    }

    public void TakeDamage(int damage)
    {
        EnemyHealth -= damage;

        GameObject CanvasChild = transform.GetChild(0).gameObject;
        GameObject HealthBarChild = CanvasChild.transform.GetChild(0).gameObject;
        HealthBarChild.GetComponent<HealthBar>().ChangeHealth(EnemyHealth);

    }
}
