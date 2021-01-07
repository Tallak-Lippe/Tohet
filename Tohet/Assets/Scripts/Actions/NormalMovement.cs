using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalMovement : Action
{
    GameObject player;
    Rigidbody rb;
    Animator animator;
    Transform transform;
    
    float vertical = 0;
    float horizontal = 0;

    MovementInfo info;
    

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

        Vector3 velocity = Vector3.Lerp(((Vector3.forward * vertical + Vector3.right * horizontal).normalized * info.speed), rb.velocity, info.movementBlend);

        animator.SetBool("isWalking", (velocity.magnitude > info.animationTreshold));

        velocity.y = 0;

        if(velocity.magnitude != 0)
        {
            transform.LookAt(transform.position + velocity);
        }

        rb.velocity = velocity;
    }

    public NormalMovement(GameObject _player, MovementInfo _info)
    {
        player = _player;
        rb = player.GetComponent<Rigidbody>();
        animator = player.GetComponent<Animator>();
        transform = player.GetComponent<Transform>();
        info = _info;
    }
}