using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellen_Attack_Manager : MonoBehaviour
{
    private void MeleeAttack()
    {
        AkSoundEngine.PostEvent("Play_Alien_Staff_Attack", this.gameObject);
    }
}
