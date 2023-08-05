using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class dayNightManager : MonoBehaviour
{
    // Reference
    [SerializeField] private GameObject[] _pointLights;
    [SerializeField] private GameObject[] _spotLight;
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    //[SerializeField] private GameObject ghost;
    public Color _darkFogColor;
    public Color _lightFogColor;

    // variables
    [SerializeField] private int _progress=0;


    void Start()
    {
        lightsOff();
        Debug.Log("Light on default");
    }


    void Update()
    {

        _textMeshPro.text = "Progress= " + _progress;

    }


    public void lightsOn()
    {



        // environment lights setting
        RenderSettings.ambientIntensity = 0.2f;
        RenderSettings.fogColor = _darkFogColor;
        RenderSettings.fogDensity = 0.03f;;

        // sounds and vfx

        // celling spot light
        for(int i =0; i < _progress; i++) 
        {
            if ( _progress <= _spotLight.Length )
            {
                _spotLight[i].SetActive( true );
                _pointLights[i*2].SetActive( true );
                _pointLights[(i*2) + 1].SetActive( true );

                Debug.Log("light number " + i + "is offed");
            }
            else
            {
                Debug.Log("in else");
                Debug.Log(_progress + "ALL Lights are ON!!");
            }
        }
        _progress += 1;
    }

    public void lightsOff() 
    {
        


        // environment lights setting
        RenderSettings.ambientIntensity = 0.5f;
        RenderSettings.fogColor = _lightFogColor;
        RenderSettings.fogDensity = 0.01f;

       
        // sounds and vfx

        // celling spot light
        foreach (GameObject pointLight in _pointLights)
        { 
            if (pointLight != null)
            {
                pointLight.gameObject.SetActive(false);
            }    
        }
        // lamp lights
        foreach (GameObject spotLight in _spotLight)
        {
            if (spotLight != null)
            {
                spotLight.SetActive(false);
            }
        }
    }


}
