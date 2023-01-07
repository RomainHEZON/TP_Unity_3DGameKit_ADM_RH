using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellen_FT_Manager : MonoBehaviour
{
    private TerrainCheckData terrainCheck;

    private void PlayRun()
    {
        AkSoundEngine.SetSwitch("Loco_Switch", "Run", this.gameObject);
        AkSoundEngine.PostEvent("Play_Ellen_Footstep", this.gameObject);
    }

    private void PlayLandForward()
    {
        AkSoundEngine.SetSwitch("Loco_Switch", "Forward", this.gameObject);
        AkSoundEngine.PostEvent("Play_Ellen_Footstep", this.gameObject);
    }

    private void PlayLandForwardRoll()
    {
        AkSoundEngine.SetSwitch("Loco_Switch", "Roll", this.gameObject);
        AkSoundEngine.PostEvent("Play_Ellen_Footstep", this.gameObject);
    }
    private void PlayLandIdle()
    {
        AkSoundEngine.SetSwitch("Loco_Switch", "Idle", this.gameObject);
        AkSoundEngine.PostEvent("Play_Ellen_Footstep", this.gameObject);
    }

    private void PlayJump()
    {
        AkSoundEngine.SetSwitch("Loco_Switch", "Run", this.gameObject);
        AkSoundEngine.PostEvent("Play_Ellen_Footstep", this.gameObject);
    }
}
