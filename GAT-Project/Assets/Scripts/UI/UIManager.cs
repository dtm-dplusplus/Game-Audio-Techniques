using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("UIManager")]
    [Tooltip("Should mouse be visible on start")]
    public bool MouseStartVisible = true;
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

        if (MouseStartVisible)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void PlayHoveredClip()
    {
        if (SoundSource && HoveredClip) SoundSource.PlayOneShot(HoveredClip);
    }

    public void PlaySelectedClip()
    {
        if (SoundSource && SelectedClip) SoundSource.PlayOneShot(SelectedClip);
    }

    public void PlayReleasedClip()
    {
        if (SoundSource && ReleasedClip) SoundSource.PlayOneShot(ReleasedClip);
    }

    public void PlaySliderClip()
    {
        if (SoundSource && SliderClip) SoundSource.PlayOneShot(SliderClip);
    }

    public void QuitToDesktop()
    {
        Application.Quit();
    }
}