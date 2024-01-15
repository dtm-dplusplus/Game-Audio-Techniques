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

        if (AudioSource) AudioSource.volume = 0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            if (AudioSource) AudioSource.volume = AudioSourceVolume;
    }
    

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            if (AudioSource) AudioSource.volume = 0f;
    }
}

