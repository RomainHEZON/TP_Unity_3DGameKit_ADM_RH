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
}
