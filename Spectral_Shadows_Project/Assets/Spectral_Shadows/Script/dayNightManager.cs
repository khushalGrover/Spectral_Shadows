using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dayNightManager : MonoBehaviour
{

    public GameObject[] lights;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lightsOn()
    {
        foreach (GameObject light in lights)
        {
            if (light != null)
            {
                light.gameObject.SetActive(false);
            }
        }
    }

    public void lightsOff() 
    {
        foreach(GameObject light in lights)
        { 
            if (light != null)
            {
                light.gameObject.SetActive(true);
            }    
        }
    }


}
