using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineSwitch : MonoBehaviour
{
    public List<LineRenderer> lines
        ;
    public bool on;

    private void Start()
    {
        if (on)
        {
            TurnOnLineRenderers();
        }
        else
        {
            TurnOffLineRenderers();
        }
    }

    public void TurnOnLineRenderers()
    {
        foreach (LineRenderer line in lines)
        {
            line.enabled = true;
            on = true;
        }
    }

    public void TurnOffLineRenderers()
    {
        foreach (LineRenderer line in lines)
        {
            line.enabled = false;
            on = false;
        }
    }

    public void ToggleLineRenderers()
    {
        if (on)
        {
            TurnOffLineRenderers();
        }
        else
        {
            TurnOnLineRenderers();
        }
    }
}
