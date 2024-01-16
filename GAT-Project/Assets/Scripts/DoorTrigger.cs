using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator Door = null;
    public BoxCollider TriggerVolume = null;
    public bool IsOpen = false;

    public AudioSource DoorAudioSource = null;
    public AudioClip OpenClip = null;
    public AudioClip CloseClip = null;

    // Start is called before the first frame update
    void Start()
    {
        Door = GetComponent<Animator>();
        TriggerVolume = GetComponent<BoxCollider>();
        DoorAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (DoorAudioSource && OpenClip) DoorAudioSource.PlayOneShot(OpenClip) ;
    }

    private void OnTriggerStay(Collider other)
    {
        // if (other.CompareTag("Player")) Door.Play("door_3_opened");
        if (other.CompareTag("Player"))
        {
            Door.SetTrigger("character_nearby");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Door.ResetTrigger("character_nearby");
            if (DoorAudioSource && CloseClip) DoorAudioSource.PlayOneShot(CloseClip);
        }
    }
}
