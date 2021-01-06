using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalButton : MonoBehaviour
{
    public GameEvent ButtonPressed;

    public KeyCode debugKey;

    private void Update()
    {
        if (Input.GetKeyDown(debugKey))
        {
            ButtonPressed.Raise();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        ButtonPressed.Raise();
    }
}
