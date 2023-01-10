using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eeldog_Manager : MonoBehaviour
{
    //Eeldogs
    private void EeldogEmerge()
    {
        AkSoundEngine.PostEvent("Play_Eeldog_Emerge", this.gameObject);

    }

    private void EeldogDive()
    {
        AkSoundEngine.PostEvent("Play_Eeldog_Dive", this.gameObject);

    }
}
