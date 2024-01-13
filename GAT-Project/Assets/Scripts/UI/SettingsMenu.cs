using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    Slider MasterVolumeSlider;
    Slider AmbienceVolumeSlider;


    private void Start()
    {
        MasterVolumeSlider = GameObject.FindGameObjectWithTag("MasterVolumeSlider").GetComponent<Slider>();
        if(MasterVolumeSlider) MasterVolumeSlider.value = AudioListener.volume;
    }

    public void SetMasterVolume()
    {
        if (MasterVolumeSlider)
        {
            AudioListener.volume = MasterVolumeSlider.value;
            Debug.Log("New volume: " + MasterVolumeSlider.value);
        }
    }

}
