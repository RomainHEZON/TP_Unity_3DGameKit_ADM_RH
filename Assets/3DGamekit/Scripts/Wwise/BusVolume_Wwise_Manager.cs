using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BusVolume_Wwise_Manager : MonoBehaviour
{
    public Slider thisSlider;
    public float masterVolume = 1;
    public float musicVolume = 1;
    public float preMasterVolume = 1;

    public void SetSpecificVolume(string whatValue)
    {
        float sliderValue = thisSlider.value;

        if (whatValue == "Master")
        {
            masterVolume = thisSlider.value;
            AkSoundEngine.SetRTPCValue("Master_Volume", masterVolume);
        }

        if (whatValue == "Music")
        {
            masterVolume = thisSlider.value;
            AkSoundEngine.SetRTPCValue("Music_Volume", musicVolume);
        }

        if (whatValue == "PreMaster")
        {
            masterVolume = thisSlider.value;
            AkSoundEngine.SetRTPCValue("PreMaster_Volume", preMasterVolume);
        }
    }
}
