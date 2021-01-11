using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalButton : MonoBehaviour
{
    public GameEvent ButtonPressed;

    public List<string> tags;
    

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
        if(TagCompare(other))
        {
            ButtonPressed.Raise();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (RaiseOnExit && TagCompare(other))
        {
            ButtonPressed.Raise();
        }
    }

    private bool TagCompare(Collider other)
    {
        foreach(string tag in tags)
        {
            if (other.CompareTag(tag))
            {
                return true;
            }
        }
        return false;
    }
}
