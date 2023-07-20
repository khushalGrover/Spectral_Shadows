using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayNightManager : MonoBehaviour
{
    // Reference
    [SerializeField] private GameObject[] _pointLights;
    [SerializeField] private GameObject[] _spotLight;

    // variables
    /* public Material material;
     public Color _emissionColorValue;
     public float desiredValue;
     public float _intensity;
     public float decrease; */

    public Color _darkFogColor;
    public Color _lightFogColor;



    void Update()
    {
        
        // NOT WROKING PROPERY
        //material.SetVector("_EmissionColor", _emissionColorValue * _intensity);
        //_intensity = _intensity - decrease;
       //  material.SetColor("_EmissionColor", _emissionColorValue * Mathf.Pow(2, _intensity));

        // https://forum.unity.com/threads/change-a-materials-emission-color-intensity-property.611206/

    }


    public void lightsOn()
    {
        RenderSettings.ambientIntensity = 0.2f;
        RenderSettings.fogColor = _darkFogColor;
        RenderSettings.fogDensity = 0.03f;

        foreach ( GameObject spotLight in _spotLight )
        {
            if ( spotLight != null )
            {
                spotLight.SetActive( false );
            }
        }

        foreach (GameObject pointLight in _pointLights)
        {
            if (pointLight != null)
            {
                pointLight.gameObject.SetActive(false);
                
            }
        }
    }

    public void lightsOff() 
    {
        RenderSettings.ambientIntensity = 0.5f;
        RenderSettings.fogColor = _lightFogColor;
        RenderSettings.fogDensity = 0.01f;

        foreach (GameObject pointLight in _pointLights)
        { 
            if (pointLight != null)
            {
                pointLight.gameObject.SetActive(true);
            }    
        }

        foreach (GameObject spotLight in _spotLight)
        {
            if (spotLight != null)
            {
                spotLight.SetActive(true);
            }
        }
    }


}
