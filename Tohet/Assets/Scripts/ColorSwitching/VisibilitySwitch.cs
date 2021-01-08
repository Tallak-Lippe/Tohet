using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilitySwitch : MonoBehaviour
{

    public List<MeshRenderer> renderers;
    public bool on;

    private void Start()
    {
        if (on)
        {
            TurnOnMeshRenderers();
        }
        else
        {
            TurnOffMeshRenderers();
        }
    }

    public void TurnOnMeshRenderers()
    {
        foreach(MeshRenderer renderer in renderers)
        {
            renderer.enabled = true;
            on = true;
        }
    }

    public void TurnOffMeshRenderers()
    {
        foreach (MeshRenderer renderer in renderers)
        {
            renderer.enabled = false;
            on = false;
        }
    }

    public void ToggleMeshRenderers()
    {
        if (on)
        {
            TurnOffMeshRenderers();
        }
        else
        {
            TurnOnMeshRenderers();
        }
    }
}
