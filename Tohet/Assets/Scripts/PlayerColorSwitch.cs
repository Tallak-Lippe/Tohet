using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorSwitch : MonoBehaviour
{
    public new MeshRenderer renderer;

    public int colorIndex;

    bool toggle = false;

    public void ToggleVisibility()
    {
        toggle = true;
    }

    private void LateUpdate()
    {
        if (toggle)
        {
            if (SwitchColor.currentColorIndex != colorIndex)
            {
                if (CameraControl._2D)
                {
                    TurnOnVisibility();
                }
                else if (!renderer.enabled)
                {
                    TurnOnVisibility();
                }
            }
            else
            {
                if (CameraControl._2D)
                {
                    TurnOffVisibility();
                }
                else if (!renderer.enabled)
                {
                    TurnOnVisibility();
                }
            }
            toggle = false;
        }
    }

    public void TurnOnVisibility()
    {
        renderer.enabled = true;
    }

    public void TurnOffVisibility()
    {
        renderer.enabled = false;
    }
  
}
