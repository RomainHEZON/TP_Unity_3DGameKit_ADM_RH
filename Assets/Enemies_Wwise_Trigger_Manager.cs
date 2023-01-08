using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies_Wwise_Trigger_Manager : MonoBehaviour
{

    // Chomper 
    public void ChomperDeath()
    {
        AkSoundEngine.PostEvent("Play_SFX_Chomper_Death", this.gameObject);
    }

    public void ChomperAttack()
    {
        AkSoundEngine.PostEvent("Play_SFX_Chomper_Attack", this.gameObject);
    }

    // Grenadier
    public void GrenadierFT()
    {
        AkSoundEngine.PostEvent("Play_Grenadier_Footsteps", this.gameObject);
    }

    public void GrenadierRangeAttack()
    {
        AkSoundEngine.PostEvent("Play_Attack_Range_Fire", this.gameObject);
    }

    public void GrenadierShield()
    {
        AkSoundEngine.PostEvent("Play_Shield", this.gameObject);
    }

    public void GrenadierCloseRangeAttack()
    {
        AkSoundEngine.PostEvent("Play_Attack_Close", this.gameObject);
    }

    public void GrenadierGetHit()
    {
        AkSoundEngine.PostEvent("Play_Get_Hit_Behind", this.gameObject);
    }
}

