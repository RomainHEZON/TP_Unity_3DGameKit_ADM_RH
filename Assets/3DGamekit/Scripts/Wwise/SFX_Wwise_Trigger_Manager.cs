using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_Wwise_Trigger_Manager : MonoBehaviour
{
    public void HealthBoxTrigger01()
    {
        AkSoundEngine.PostEvent("Play_SFX_HealthBox_Open_01", this.gameObject);
    }

    public void HealthBoxTrigger02()
    {
        AkSoundEngine.PostEvent("Play_SFX_HealthBox_Open_02", this.gameObject);
    }

    public void StaffPickUp()
    {
        AkSoundEngine.PostEvent("Play_SFX_Alien_Staff_Pickup", this.gameObject);
    }
}
