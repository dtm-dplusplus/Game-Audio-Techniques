using UnityEngine;

public class ButtonSounds : MonoBehaviour
{
    [Header("ButtonSounds")]
    public AudioSource SoundSource = null;
    public AudioClip HoveredClip = null;
    public AudioClip SelectedClip = null;
    public AudioClip ReleasedClip = null;
    public AudioClip SliderClip = null;

    private void Start()
    {
        SoundSource = GetComponent<AudioSource>();
        SoundSource.ignoreListenerPause = true;
    }
    public void PlayHoveredClip()
    {
        if (SoundSource && HoveredClip) SoundSource.PlayOneShot(HoveredClip);
    }

    public void PlaySelectedClip()
    {
        if (SoundSource && SelectedClip) SoundSource.PlayOneShot(SelectedClip);
    }

    public void PlayReleasedClipClip()
    {
        if (SoundSource && ReleasedClip) SoundSource.PlayOneShot(ReleasedClip);
    }

    public void PlaySliderClip()
    {
        if (SoundSource && SliderClip) SoundSource.PlayOneShot(SliderClip);
    }
}
