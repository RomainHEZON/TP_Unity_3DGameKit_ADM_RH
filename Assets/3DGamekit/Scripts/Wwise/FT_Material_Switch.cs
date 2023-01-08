using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FT_Material_Switch : MonoBehaviour
{
    private enum CURRENT_TERRAIN { STONE, PUDDLE, GRASS, METAL, VEGETATION };

    [SerializeField]
    private CURRENT_TERRAIN currentTerrain;

    /*[SerializeField]
    private AK.Wwise.Event footstepsEvent;*/

    [SerializeField]
    private AK.Wwise.Switch[] terrainSwitch;

    private void CheckTerrain()
    {
        RaycastHit[] hit;

        hit = Physics.RaycastAll(transform.position, Vector3.down, 0.5f);

        foreach (RaycastHit rayhit in hit)
        {
            if (rayhit.transform.gameObject.layer == LayerMask.NameToLayer("Stone"))
            {
                currentTerrain = CURRENT_TERRAIN.STONE;
                AkSoundEngine.SetSwitch("Material_Switch", "Stone", this.gameObject);

            }
            else if (rayhit.transform.gameObject.layer == LayerMask.NameToLayer("WaterGeometry"))
            {
                currentTerrain = CURRENT_TERRAIN.GRASS;
                AkSoundEngine.SetSwitch("Material_Switch", "Grass", this.gameObject);

            }
            else if (rayhit.transform.gameObject.layer == LayerMask.NameToLayer("Environment"))
            {
                currentTerrain = CURRENT_TERRAIN.PUDDLE;
                AkSoundEngine.SetSwitch("Material_Switch", "Puddle", this.gameObject);
            }
            else if (rayhit.transform.gameObject.layer == LayerMask.NameToLayer("Metal"))
            {
                currentTerrain = CURRENT_TERRAIN.METAL;
                AkSoundEngine.SetSwitch("Material_Switch", "Metal", this.gameObject);
            }
            
        }

        /*hit = Physics.RaycastAll(transform.position, Vector3.up, 2f);

        foreach (RaycastHit rayhit in hit)
        {
            if (rayhit.transform.gameObject.layer == LayerMask.NameToLayer("Vegetation"))
            {
                currentTerrain = CURRENT_TERRAIN.VEGETATION;
                AkSoundEngine.PostEvent("Play_Vine", this.gameObject);
            }
        }*/
    }



    private void Update()
    {
        CheckTerrain();
    }

    private void PlayFootstep(int terrain)
    {
        terrainSwitch[terrain].SetValue(this.gameObject);
    }


}
