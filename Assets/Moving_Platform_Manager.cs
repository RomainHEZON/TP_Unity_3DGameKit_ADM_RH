using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Platform_Manager : MonoBehaviour
{
    [SerializeField] AK.Wwise.RTPC MovingPlatformRTPC;

    private void Update()
    {

        if (transform.position.y < -4.95f)
        {
            AkSoundEngine.SetRTPCValue(MovingPlatformRTPC.Name, 0);
        }

        else if (transform.position.y >= -4.95f && transform.position.y <= 1.34f)
        {
            AkSoundEngine.SetRTPCValue(MovingPlatformRTPC.Name, 1.5f);
        }

        else if (transform.position.y > 1.34f)
        {
            AkSoundEngine.SetRTPCValue(MovingPlatformRTPC.Name, 0);
        }
    }
}
