using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalDetection : MonoBehaviour
{
    public GameEvent levelComplete;

    bool playerThrough = false;
    bool diamondThrough = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerThrough = true;
        }
        else if (other.CompareTag("Diamond"))
        {
            diamondThrough = true;
        }

        if (diamondThrough && playerThrough)
        {
            levelComplete.Raise();
        }
        
    }
}
