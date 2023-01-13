using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_Wwise_Trigger_Manager : MonoBehaviour
{
    public void HealthBoxTrigger01()
    {
        AkSoundEngine.PostEvent("Play_SFX_HealthBox_Open_01", this.gameObject);
    }

    public void StaffPickUp()
    {
        AkSoundEngine.PostEvent("Play_SFX_Alien_Staff_Pickup", this.gameObject);
        AkSoundEngine.PostEvent("Play_SFX_After_Activation", this.gameObject);
    }

    public void SwitchActivated()
    {
        AkSoundEngine.PostEvent("Play_SFX_Crystal_Switch_Activated", this.gameObject);
        AkSoundEngine.PostEvent("Play_SFX_After_Activation", this.gameObject);
    }

    public void PressurePad()
    {
        AkSoundEngine.PostEvent("Set_State_Explo", this.gameObject);
        AkSoundEngine.PostEvent("Play_SFX_Pressure_Pad_Activated", this.gameObject);
        AkSoundEngine.PostEvent("Play_SFX_After_Activation", this.gameObject);
    }

    public void PressurePad02()
    {
        AkSoundEngine.PostEvent("Play_SFX_Pressure_Pad_Activated_02", this.gameObject);
        AkSoundEngine.PostEvent("Play_SFX_After_Activation", this.gameObject);
    }

    public void BoxBreak()
    {
        AkSoundEngine.PostEvent("Play_Boxes_Break", this.gameObject);
    }

    public void HugeDoorOpen01()
    {
        AkSoundEngine.PostEvent("Play_SFX_Huge_Door_Open_01", this.gameObject);

    }

    public void HugeDoorOpen02()
    {
        AkSoundEngine.PostEvent("Play_SFX_Huge_Door_Open_02", this.gameObject);

    }
    public void HugeDoorOpen03()
    {
        AkSoundEngine.PostEvent("Play_SFX_Huge_Door_Open_03", this.gameObject);
        AkSoundEngine.PostEvent("Play_Music_Theme_Grenadier_End", this.gameObject);


    }

    public void Level2DoorOpen01()
    {
        AkSoundEngine.PostEvent("Play_SFX_Door_Open_01", this.gameObject);

    }

    public void Level2DoorOpen02()
    {
        AkSoundEngine.PostEvent("Play_SFX_Door_Open_02", this.gameObject);

    }

    public void Level2DoorOpen03()
    {
        AkSoundEngine.PostEvent("Play_SFX_Door_Open_01", this.gameObject);

    }

    public void Level2DoorOpen04()
    {
        AkSoundEngine.PostEvent("Play_SFX_Door_Open_01", this.gameObject);

    }

    public void SpaceshipLanding()
    {
        AkSoundEngine.PostEvent("Play_Spaceship_Landing", this.gameObject);
    }

    public void SpaceshipIdle()
    {
        AkSoundEngine.PostEvent("Play_Spaceship_BC", this.gameObject);

    }


}
