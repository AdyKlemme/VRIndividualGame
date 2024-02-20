using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ExitData : MonoBehaviour
{
    private InputData _inputData;
    private bool _okayToExit = true;

    void Start()
    {
        Debug.Log("Started");
        _inputData = GetComponent<InputData>();
    }

    void Update()
    {
        Debug.Log("Updated");
        if (_okayToExit)
        {
            if (_inputData._leftController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool _yButtonPressed))
            {
                if (_yButtonPressed)
                {
                    Debug.Log("A pressed");
                    _okayToExit = false;
                    GameObject save = GameObject.Find("GameController");
                    save.GetComponent<SaveLoad>().BeginShutdown();
                }
            }

        }
    }
}
