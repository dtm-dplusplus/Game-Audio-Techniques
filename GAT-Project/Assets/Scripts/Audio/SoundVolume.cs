using UnityEngine;

public class SoundBoxVoulme : MonoBehaviour
{
    [Header("Sound Volume")]
    [Tooltip("Volume Audio Source")]
    public AudioSource AudioSource = null;
    [Tooltip("Should Loop audio clip")]
    public bool LoopAudioClip = true;
    [Tooltip("VolumeLevel for sound volume")]
    public float AudioSourceVolume = 1f;

    private void Start()
    {
        if (AudioSource == null)
            AudioSource = GetComponent<AudioSource>();

        if (AudioSource)
            AudioSource.loop = LoopAudioClip;

        if (AudioSource && LoopAudioClip) 
            AudioSource.volume = 0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && AudioSource)
        {
            Debug.Log("Enter");
            if (LoopAudioClip) AudioSource.volume = AudioSourceVolume;
            else AudioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && AudioSource)
            AudioSource.volume = 0f;
    }
}