using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Lighting Preset", menuName ="Scriptables/lighting Preset",order =1)]
public class LightingPreset : ScriptableObject
{
    public Gradient AmbientColor;
    public Gradient Brightness;
    public Gradient FogColor;
    public Gradient DirectionalColor; 
}
