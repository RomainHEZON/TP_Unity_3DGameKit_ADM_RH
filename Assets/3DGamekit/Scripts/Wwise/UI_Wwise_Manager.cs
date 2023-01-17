using Gamekit3D;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class UI_Wwise_Manager : MonoBehaviour
{
   /* public Slider VolumeSlider;

    [SerializeField] private AK.Wwise.RTPC VolumeRTPC;

    [SerializeField] private AK.Wwise.RTPC HealthRTPC;*/


    // Pointer UI 
    public void PointerHover()
    {
        AkSoundEngine.PostEvent("Play_UI_Menu_Mouse_Over", this.gameObject);
    }
    public void PointerConfirm()
    {
        AkSoundEngine.PostEvent("Play_UI_Menu_Selection", this.gameObject);
    }

    public void PointerBack()
    {
        AkSoundEngine.PostEvent("Play_UI_Menu_Cancel", this.gameObject);
    }

    public void PointerStartGame()
    {
        AkSoundEngine.PostEvent("Play_UI_Game_Start", this.gameObject);
        AkSoundEngine.PostEvent("Stop_SFX_Chomper_Idle", this.gameObject);
    }

    public void PointerQuitGame()
    {
        AkSoundEngine.PostEvent("Play_UI_Game_Quit", this.gameObject);
    }

    public void PointerUIClose()
    {
        AkSoundEngine.PostEvent("Play_UI_Game_Resume", this.gameObject);
    }

   /* public void PointerVolumeSlider()
    {
        AkSoundEngine.SetRTPCValue(VolumeRTPC.Name, VolumeSlider.value);

        AkSoundEngine.PostEvent("Play_UI_Menu_Volume_Slider", this.gameObject);
    }*/

    // Dialogue UI 
    public void DialogueStart()
    {
        AkSoundEngine.PostEvent("Play_UI_Dialogue_Start", this.gameObject);
    }

}
