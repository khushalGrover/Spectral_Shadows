using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayNightManager : MonoBehaviour
{
    // Reference
    [SerializeField] private GameObject[] _pointLights;
    [SerializeField] private GameObject[] _spotLight;
    [SerializeField] private GameObject ghost;


    // variables
    /* public Material material;
     public Color _emissionColorValue;
     public float desiredValue;
     public float _intensity;
     public float decrease; */
    public Color _darkFogColor;
    public Color _lightFogColor;


    void Start()
    {
        lightsOff();
        Debug.Log("Light on default");
    }


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
        // environment lights setting
        RenderSettings.ambientIntensity = 0.2f;
        RenderSettings.fogColor = _darkFogColor;
        RenderSettings.fogDensity = 0.03f;

        // to do add fade in effect or dissolve effect
        ghost.SetActive(true);

        // sounds and vfx

        // celling spot light
        foreach ( GameObject spotLight in _spotLight )
        {
            if ( spotLight != null )
            {
                spotLight.SetActive( false );
            }
        }
        // lamp lights
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
        // environment lights setting
        RenderSettings.ambientIntensity = 0.5f;
        RenderSettings.fogColor = _lightFogColor;
        RenderSettings.fogDensity = 0.01f;

        // to do add fade in effect or dissolve effect and give random rotation to spot light
        ghost.SetActive(false);

        // sounds and vfx

        // celling spot light
        foreach (GameObject pointLight in _pointLights)
        { 
            if (pointLight != null)
            {
                pointLight.gameObject.SetActive(true);
            }    
        }
        // lamp lights
        foreach (GameObject spotLight in _spotLight)
        {
            if (spotLight != null)
            {
                spotLight.SetActive(true);
            }
        }
    }


}
