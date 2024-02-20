using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void BeginShutdown()
    {
        Debug.Log("BeginShutdown reached");
        GetComponent<SaveData>().DataSaving();
        SaveData();
    }

    public void SaveData()
    {
        Application.Quit();
    }
}
