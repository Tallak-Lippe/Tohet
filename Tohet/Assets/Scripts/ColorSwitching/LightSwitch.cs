using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GlobalColor lightColor;
    public Light light;
    List<Color> colors;
    public int startColorIndex;

    public int currentColorIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        colors = lightColor.colors;
        currentColorIndex = startColorIndex;
        light.color = colors[startColorIndex];
    }

    public void SetColor(int index)
    {
        light.color = colors[index];
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
