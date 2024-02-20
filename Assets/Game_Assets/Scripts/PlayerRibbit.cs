using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerRibbit : MonoBehaviour
{
    [SerializeField] public AudioClip ribbitSound;
    private InputData _inputData;
    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        _inputData= GetComponent<InputData>();
        _audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_inputData._rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool _aButtonPressed))
        {
            if (_aButtonPressed)
            {
                _audioSource.clip = ribbitSound;
                _audioSource.Play();

            }
        }
    }
}
