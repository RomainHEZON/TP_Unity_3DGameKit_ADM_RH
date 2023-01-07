using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FootstepCollectionEntry
{
    public string textureName;
    public AK.Wwise.Switch footstepCollection;
}

public class Footstep_Terrain : MonoBehaviour
{
    //public AudioClip defaultSound;

    public List<FootstepCollectionEntry> collections;

    private AK.Wwise.Switch currentCollection;
    private TerrainCheckData terrainCheck;
    private string currentLayer;

    // Start is called before the first frame update
    void Start()
    {
        terrainCheck = new TerrainCheckData();
    }

    public void Update()
    {
        CheckLayers();
    }

    public void CheckLayers()
    {
        //raycast down
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.5f))
        {
            Debug.Log("je scan le terrain");

            if (hit.transform.GetComponent<Terrain>() != null)
            {
                Debug.Log("je touche le terrain");

                Terrain t = hit.transform.GetComponent<Terrain>();

                if (currentLayer != terrainCheck.GetLayerName(transform.position, t))
                {
                    Debug.Log("je touche le terrain :" + currentLayer);

                    currentLayer = terrainCheck.GetLayerName(transform.position, t);
                    currentCollection = null;
                    foreach (FootstepCollectionEntry fc in collections)
                    {
                        if (currentLayer == fc.textureName)
                        {
                            Debug.Log("le terrain" + currentLayer +"trouve le switch" + fc);

                            fc.footstepCollection.SetValue(gameObject);

                            currentCollection = fc.footstepCollection;

                            Debug.Log("terrain switché");

                            break;

                        }
                    }
                }
            }
            else if (currentLayer != LayerMask.LayerToName(hit.transform.gameObject.layer))
            {
                currentLayer = LayerMask.LayerToName(hit.transform.gameObject.layer);
                currentCollection = null;
                foreach (FootstepCollectionEntry fc in collections)
                {
                    if (currentLayer.Contains(fc.textureName))
                    {
                        fc.footstepCollection.SetValue(this.gameObject);

                        currentCollection = fc.footstepCollection;

                        break;
                    }
                }
            }
        }
    }
}
