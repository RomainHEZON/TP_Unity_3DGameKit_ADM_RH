using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies_Wwise_Trigger_Manager : MonoBehaviour
{
    public void ChomperDeath()
    {
        AkSoundEngine.PostEvent("Play_SFX_Chomper_Death", this.gameObject);
    }

    public void ChomperAttack()
    {
        AkSoundEngine.PostEvent("Play_SFX_Chomper_Attack", this.gameObject);

    }

    public void ChomperIdle()
    {
        AkSoundEngine.PostEvent("Play_SFX_Chomper_Idle", this.gameObject);

    }
}
