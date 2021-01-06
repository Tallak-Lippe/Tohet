using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalMovement : Action
{
    GameObject player;
    Rigidbody rb;
    
    float vertical = 0;
    float horizontal = 0;

    float speed = 1.5f;

    public void Act()
    {
        if (Input.GetKey(Inputs.forward))
            vertical = 1;
        else if (Input.GetKey(Inputs.backwards))
            vertical = -1;
        else
            vertical = 0;

        if (Input.GetKey(Inputs.right))
            horizontal = 1;
        else if (Input.GetKey(Inputs.left))
            horizontal =- 1;
        else
            horizontal = 0;

        rb.velocity = (Vector3.forward * vertical + Vector3.right * horizontal) * speed; 
    }

    public NormalMovement(GameObject _player)
    {
        player = _player;
        rb = player.GetComponent<Rigidbody>();
    }
}