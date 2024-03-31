using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorObject : GameUnit
{
  public ColorType colorType;
    [SerializeField] MeshRenderer meshRenderer;
    [SerializeField] ColorData colorData;
    public void ChangColor( ColorType colorType )
    {
        this.colorType = colorType;
        meshRenderer.material = colorData.GetColorMats(colorType);
    }
}
