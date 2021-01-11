using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderSwitch : MonoBehaviour
{
    public List<Collider> colliders;
    public bool on;

    private void Start()
    {
        if (on)
        {
            TurnOnColliders();
        }
        else
        {
            TurnOffColliders();
        }
    }

    public void TurnOnColliders()
    {
        foreach (Collider collider in colliders)
        {
            collider.enabled = true;
            on = true;
        }
    }

    public void TurnOffColliders()
    {
        foreach (Collider collider in colliders)
        {
            collider.enabled = false;
            on = false;
        }
    }

    public void ToggleColliders()
    {
        if (on)
        {
            TurnOffColliders();
        }
        else
        {
            TurnOnColliders();
        }
    }
}
