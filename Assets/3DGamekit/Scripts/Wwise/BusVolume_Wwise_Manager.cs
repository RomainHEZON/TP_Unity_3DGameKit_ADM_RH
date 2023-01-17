using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BusVolume_Wwise_Manager : MonoBehaviour
{
    public Slider thisSlider;
    public float master_Volume = 1;
    public float music_Volume = 1;
    public float SFX_Volume = 1;

    // Volume RTPCs 

    [SerializeField] AK.Wwise.RTPC MasterVolumeRTPC;
    [SerializeField] AK.Wwise.RTPC MusicVolumeRTPC;
    [SerializeField] AK.Wwise.RTPC SFXVolumeRTPC;

    public void SetSpecificVolume(string whatValue)
    {
        float sliderValue = thisSlider.value;

        if (whatValue == "Master_Volume")
        {
            master_Volume = thisSlider.value;
            AkSoundEngine.SetRTPCValue(MasterVolumeRTPC.Name, master_Volume);
        }

        if (whatValue == "Music_Volume")
        {
            music_Volume = thisSlider.value;
            AkSoundEngine.SetRTPCValue(MusicVolumeRTPC.Name, music_Volume);
        }

        if (whatValue == "SFX_Volume")
        {
            SFX_Volume = thisSlider.value;
            AkSoundEngine.SetRTPCValue(SFXVolumeRTPC.Name, SFX_Volume);
        }
    }
}
