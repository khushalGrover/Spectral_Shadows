using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightsManaher : MonoBehaviour
{
    // references
    [SerializeField] private Light DirectionalLight;
    [SerializeField] private LightingPreset Preset;

    // variables
    [SerializeField, Range(0, 24)] private float TimeOfDay;

    private void Update()
    {
        if (Preset == null) 
            return;

        if( Application.isPlaying )
        {
            TimeOfDay += Time.deltaTime;
            TimeOfDay %= 24; // clamp between 0-24
            UpdateLighting(TimeOfDay / 24f); 
        }
        else
        {
            UpdateLighting(TimeOfDay / 24f);
        }
    }

    private void UpdateLighting(float timePercent)
    {
        RenderSettings.ambientLight = Preset.AmbientColor.Evaluate(timePercent);
        RenderSettings.fogColor = Preset.FogColor.Evaluate(timePercent);

        if(DirectionalLight != null)
        {
            DirectionalLight.color = Preset.DirectionalColor.Evaluate(timePercent);
            DirectionalLight.transform.localRotation = Quaternion.Euler(new Vector3((timePercent * 360f) - 90f, 170f, 0));
        }
    }


    // Try to find a directional light to use if havent set one
    private void OnValidate()
    {
        if (DirectionalLight != null)
            return;

        // sereach for lighting tab sun
        if(RenderSettings.sun != null)
        {
            DirectionalLight = RenderSettings.sun;
        }
        // search scene for light that fits criteria (directional)
        else
        {
            Light[] lights = GameObject.FindObjectsOfType<Light>();
            foreach (Light light in lights)
            {
                if(light.type == LightType.Directional)
                {
                    DirectionalLight = light;
                    return;
                }
            }
        }

    }
}
