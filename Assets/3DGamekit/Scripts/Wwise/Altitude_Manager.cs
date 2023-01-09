using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Gamekit3D.Message;
using UnityEngine.Serialization;

public class Altitude_Manager : MonoBehaviour
{

    private void Start()
    {
        // wAkSoundEngine.PostEvent("Play_AMB_PAD_Wind_Elevation", this.gameObject);
    }
    private void Update()
    {
        // AkSoundEngine.PostEvent("Play_PAD_Wind", this.gameObject);
        // AkSoundEngine.SetRTPCValue(_ElevationRTPC.Name, transform.position.y);

        if (transform.position.y <= 22)
        {
            AkSoundEngine.SetState("Wind_State", "OFF"); 
        }

        else if (transform.position.y >= 22 && transform.position.y <= 35)
        {
            AkSoundEngine.SetState("Wind_State", "Medium");
        }

        else if (transform.position.y >= 35)
        {
            AkSoundEngine.SetState("Wind_State", "Strong");
        }
    }
}
