using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chomper_Manager : MonoBehaviour
{
    public GameObject Reference;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Reference.transform.position.x <= 10 && Reference.transform.position.z <= 10)
        {
            AkSoundEngine.PostEvent("Set_State_Fight_Chomper", this.gameObject);
        }
    }
}
