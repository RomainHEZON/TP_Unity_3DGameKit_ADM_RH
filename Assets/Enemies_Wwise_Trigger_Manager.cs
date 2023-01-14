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

    private void ChomperFT()
    {
        AkSoundEngine.PostEvent("Play_Chomper_FT_Walk", this.gameObject);
    }

    public void ChomperIdle()
    {
        AkSoundEngine.PostEvent("Play_SFX_Chomper_Idle", this.gameObject);

    }

    public void ChomperSpotted()
    {
        AkSoundEngine.PostEvent("Play_SFX_Chomper_Spotted", this.gameObject);

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

    public void GrenadierDeath()
    {
        AkSoundEngine.PostEvent("Play_Grenadier_Death", this.gameObject);
    }


    public void GrenadierVOAttack()
    {
        AkSoundEngine.PostEvent("Play_Grenadier_Vox_Attack", this.gameObject);
    }

    // Set State Music
    public void SetStateExplo()
    {
        AkSoundEngine.PostEvent("Set_State_Explo", this.gameObject);
    }

    public void SetStateEnd()
    {
        AkSoundEngine.PostEvent("Set_State_End", this.gameObject);
    }

    public void SetStateFightChomper()
    {
        AkSoundEngine.PostEvent("Set_State_End", this.gameObject);
    }

    // Spitter

    public void SpitterDeath()
    {
        AkSoundEngine.PostEvent("Play_SFX_Spitter_Death", this.gameObject);

    }

    private void SpitterAttack()
    {
        AkSoundEngine.PostEvent("Play_SFX_Spitter_Attack", this.gameObject);

    }



}

