using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalButton : MonoBehaviour
{
    public GameEvent ButtonPressed;

    public bool RaiseOnExit = true;

    public KeyCode debugKey;

    private void Update()
    {
        if (Input.GetKeyDown(debugKey))
        {
            ButtonPressed.Raise();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        ButtonPressed.Raise();
    }

    private void OnTriggerExit(Collider other)
    {
        if (RaiseOnExit)
        {
            ButtonPressed.Raise();
        }
    }
}
