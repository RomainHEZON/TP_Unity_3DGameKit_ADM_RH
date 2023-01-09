using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellen_Attack_Manager : MonoBehaviour
{
    // Melee Attack
    private void MeleeAttack()
    {
        AkSoundEngine.PostEvent("Play_Alien_Staff_Attack", this.gameObject);
    }

    // HP Loss

    public void HPLoss()
    {
        AkSoundEngine.PostEvent("Play_UI_HP_Loss", this.gameObject);

    }

    public void VOPain()
    {
        AkSoundEngine.PostEvent("Play_VO_Pain", this.gameObject);

    }

    public void VODeath()
    {
        AkSoundEngine.PostEvent("Play_VO_Death", this.gameObject);
        

    }

    public void DeathStinger()
    {
        AkSoundEngine.PostEvent("Play_SFX_Death_Stinger", this.gameObject);

    }

    // Shield

    public void ShieldOn()
    {
        AkSoundEngine.PostEvent("Play_Shield_Activate", this.gameObject);

    }

    
}
