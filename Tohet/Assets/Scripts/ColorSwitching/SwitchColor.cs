using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchColor : MonoBehaviour
{

    public GlobalColor globalColor;
    List<Color> colors;
    public List<MeshRenderer> meshRenderers;
    public int startColorIndex;

    public static int currentColorIndex = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        colors = globalColor.colors;
        currentColorIndex = startColorIndex; 
    }

    public void SetColor(int index)
    {
        foreach(MeshRenderer meshRenderer in meshRenderers)
        {
            meshRenderer.material.color = colors[index];
            currentColorIndex = index;
        }
    }

    public void SwitchToNextColor()
    {
        currentColorIndex += 1;
        if(currentColorIndex >= colors.Count)
        {
            currentColorIndex = 0;
        }
        SetColor(currentColorIndex);
    }
}
