using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondMovement : Action
{
    GameObject player;
    MovementInfo info;
    Rigidbody rb;

    float vertical = 0;
    float horizontal = 0;

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
            horizontal = -1;
        else
            horizontal = 0;

        Vector3 targetDirection = (Vector3.forward * vertical + Vector3.right * horizontal).normalized;
        targetDirection.y = 0;
        Vector3 velocity = Vector3.Lerp((targetDirection * info.speed), rb.velocity, info.movementBlend);

        rb.velocity = velocity;
    }

    public DiamondMovement(GameObject _player, MovementInfo _info)
    {
        player = _player;
        info = _info;
        rb = _player.GetComponent<Rigidbody>();
    }
}
