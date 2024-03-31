using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[CreateAssetMenu(fileName = "ColorData", menuName = "ScriptableObjects/ColorData", order = 1)]

public class ColorData : ScriptableObject
{
    [SerializeField] Material[] colorMats;
   
    public Material GetColorMats(ColorType colorType)
    {
        return colorMats[(int)colorType];
    }

}
