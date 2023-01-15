using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways] // Execute en Scene ET en Game 

public class Rain_Manager : MonoBehaviour
{
    [Header("Rainfall Particle System")]
    [Space]

    public ParticleSystem RainFall;

    [Header("RTPC")]
    [Space]

    [Range(0, 100)]
    [SerializeField] public float _RainIntensity = 0;
    [Space]

    [SerializeField] private AK.Wwise.RTPC _RainIntensityRTPC;

    [Header("LIGHT")]
    [Space]

    [SerializeField] private Light DirectionalLight; // Directional Light
    [Space]

    [SerializeField] private Lighting_Preset LightingPreset; // Preset de Lighting
    [Space]
    
    [SerializeField] private Material SkyboxMaterial; // Skybox Material
    [Space]

    [SerializeField] private Skybox_Lighting_Preset SkyboxLightingPreset; // Preset de Lighting de la Skybox
    [Space]

    public Color colorStart;
    public Color colorEnd;

    public float duration = 100f;

    private void Update()
    {
        AkSoundEngine.SetRTPCValue(_RainIntensityRTPC.Name, _RainIntensity); // Set Rain RTPC value en fonction du Slider

        if (_RainIntensity >= 10f)   // Si la valeur du slider >= 10 = Play l'anim de pluie
        {
            RainFall.Play();
        }
        else RainFall.Stop(); // Sinon stop l'anim


        if (LightingPreset && SkyboxLightingPreset == null)
            return;

        if (Application.isPlaying)
        {
            _RainIntensity %= 100;
            UpdateLighting(_RainIntensity / 100f); // Rotation de la Directional Light en fonction du slider  

        }
        else
        {
            UpdateLighting(_RainIntensity / 100f);
        }
    }
    private void UpdateLighting(float timePercent)
    {

        // Se réfère aux valeurs assignées aux Gradients du Lighting Preset (game object)

        RenderSettings.ambientLight = LightingPreset.AmbientColor.Evaluate(timePercent); // Ambient Color

        RenderSettings.fogColor = LightingPreset.FogColor.Evaluate(timePercent); // Fog Color

        RenderSettings.skybox.SetFloat("_Rotation", _RainIntensity); // Rotation de la Skybox en fonction du slider  

        RenderSettings.skybox.color = SkyboxLightingPreset.SkyboxColor.Evaluate(timePercent);

        float lerp = Mathf.PingPong(_RainIntensity, duration) / duration;
        RenderSettings.skybox.SetColor("_Tint", Color.Lerp(colorStart, colorEnd, lerp));

        if (DirectionalLight != null)
        {
            DirectionalLight.color = LightingPreset.DirectionalColor.Evaluate(timePercent); // Directional Color

           // DirectionalLight.transform.localRotation = Quaternion.Euler(new Vector3((timePercent * 360f) - 90f, -170, 0)); // Rotation de la Directional Light selon les valeurs définies

        }

    }
    private void OnValidate()
    {
        if (DirectionalLight != null)
            return;

        if (RenderSettings.sun != null)
        {
            DirectionalLight = RenderSettings.sun;
        }
        else
        {
            Light[] lights = GameObject.FindObjectsOfType<Light>();
            foreach (Light light in lights)
            {
                if (light.type == LightType.Directional)
                {
                    DirectionalLight = light;
                    return;
                }
            }
        }
    }
}
