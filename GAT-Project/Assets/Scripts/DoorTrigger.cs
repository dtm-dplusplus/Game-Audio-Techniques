using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator Door = null;
    public BoxCollider TriggerVolume = null;
    public bool IsOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        Door = GetComponent<Animator>();
        TriggerVolume = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Player")) Door.SetTrigger("door_3_open");
        Debug.Log("Enter");
    }

    private void OnTriggerStay(Collider other)
    {
        // if (other.CompareTag("Player")) Door.Play("door_3_opened");
        if (other.CompareTag("Player")) Door.SetTrigger("character_nearby");
        Debug.Log("Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) Door.ResetTrigger("character_nearby");
        Debug.Log("Exit");
    }
}
