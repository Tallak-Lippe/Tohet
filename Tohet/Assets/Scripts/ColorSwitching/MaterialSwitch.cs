using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwitch : MonoBehaviour
{
    public Material material;
    
    public List<Color> colors;
    
    public int startColorIndex;

    public static int currentColorIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        currentColorIndex = startColorIndex;
        
    }

    public void SetColor(int index)
    {
        
        material.color = colors[index];
        
        material.SetColor("_EmissionColor", colors[index]);
        
        currentColorIndex = index;
        
    }

    public void SwitchToNextColor()
    {
        currentColorIndex += 1;
        if (currentColorIndex >= colors.Count)
        {
            currentColorIndex = 0;
        }
        SetColor(currentColorIndex);
    }
}
