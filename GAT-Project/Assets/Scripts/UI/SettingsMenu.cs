using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Slider MasterVolumeSlider = null;
    public Slider AmbienceVolumeSlider = null;
    public AudioSource AmbienceAudioSource = null;

    private void Start()
    {
        if(!MasterVolumeSlider)
            MasterVolumeSlider = GameObject.FindGameObjectWithTag("MasterVolumeSlider").GetComponent<Slider>();

        if(MasterVolumeSlider) MasterVolumeSlider.value = AudioListener.volume;

        if (!AmbienceAudioSource)
            AmbienceAudioSource = GameObject.FindGameObjectWithTag("AmbientSoundSource").GetComponent<AudioSource>();

        if(!AmbienceVolumeSlider)
            AmbienceVolumeSlider = GameObject.FindGameObjectWithTag("AmbientVolumeSlider").GetComponent<Slider>();

        if (AmbienceVolumeSlider && AmbienceAudioSource) AmbienceVolumeSlider.value = AmbienceAudioSource.volume;

    }

    public void SetMasterVolume()
    {
        if (MasterVolumeSlider) AudioListener.volume = MasterVolumeSlider.value;
    }

    public void SetAmbientVolume()
    {
        if (AmbienceVolumeSlider && AmbienceAudioSource) AmbienceAudioSource.volume = AmbienceVolumeSlider.value;
    }
}
