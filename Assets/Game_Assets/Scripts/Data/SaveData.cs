using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveData : MonoBehaviour
{

    private void Start()
    {
     
    }
    public void DataSaving()
    {
        float tempTime = GetComponent<Timer>().FinalTime();

        bool MushState = GetComponent<FoundMushroom>().MushyState();

        //GameObject pheight = GameObject.Find("GameController");
        float playerHeight1 = GetComponent<PlayerHeight>().WriteHeight1();
        float playerHeight2 = GetComponent<PlayerHeight>().WriteHeight2();
        float playerHeight3 = GetComponent<PlayerHeight>().WriteHeight3();
        float playerAvgHeight = GetComponent<PlayerHeight>().WriteAvgHeight();
        string destination = Application.persistentDataPath + "/" 
            + System.DateTime.UtcNow.ToLocalTime().ToString("M-d-yy-HH-mm") + ".txt";

        StreamWriter writer = new StreamWriter(destination, true);

        writer.Write("Total time: ");
        writer.Write(tempTime);

        writer.Write("Was Mushroom Found: ");
        writer.Write(MushState);

        writer.Write("Player Height 1: ");
        writer.Write(playerHeight1);
        writer.Write("Player Height 2: ");
        writer.Write(playerHeight2);
        writer.Write("Player Height 3: ");
        writer.Write(playerHeight3);
        writer.Write("Player Avg Height: ");
        writer.Write(playerAvgHeight);

        writer.Close();
    }
}
