using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundVoulme : MonoBehaviour
{
    [Header("Sound Volume")]
    [Tooltip("Volume Audio Source")]
    public AudioSource VolumeAudioSource = null;

    [Tooltip("Should Loop audio clip")]
    public bool LoopAudioClip = true;

    private void Start()
    {
        if (VolumeAudioSource == null)
            VolumeAudioSource = GameObject.FindGameObjectWithTag("AudioSource").GetComponent<AudioSource>();

        if (VolumeAudioSource)
            VolumeAudioSource.loop = LoopAudioClip;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            VolumeAudioSource.Play();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            VolumeAudioSource.Stop();
    }
}

