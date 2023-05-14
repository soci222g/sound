using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class evaiorment : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioMixerSnapshot indoor;
    public AudioMixerSnapshot outdoor;

    public float transitionTime = 0.25f;

    private void OnTriggerEnter(Collider other)
    {
        indoor.TransitionTo(transitionTime);
    }

    private void OnTriggerExit(Collider other)
    {
        outdoor.TransitionTo(transitionTime);
    }
}


