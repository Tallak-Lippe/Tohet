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

        Vector3 targetDirection = (Vector3.forward * vertical + Vector3.right * horizontal).normalized;
        targetDirection.y = 0;
        Vector3 velocity = Vector3.Lerp((targetDirection * info.speed), rb.velocity, info.movementBlend);

        animator.SetBool("isWalking", (velocity.magnitude > info.animationTreshold));
        animator.SetFloat("speed", velocity.magnitude);

        velocity.y = 0;

        if(velocity.magnitude != 0)
        {
            Vector3 direction = transform.position + transform.forward;
            direction.y = transform.position.y;
            transform.LookAt(Vector3.Slerp(transform.position + targetDirection, direction , info.rotationBlend));
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