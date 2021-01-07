using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public PlayerState startPlayerState;
    public Action action;
    public MovementInfo info;
    // Start is called before the first frame update

    private void Start()
    {
        ChangeAction(startPlayerState);
    }
    // Update is called once per frame
    void Update()
    {
        action.Act();
    }

    public void ChangeAction(PlayerState playerState)
    {
        switch (playerState)
        {
            case PlayerState.normal:
                action = new NormalMovement(gameObject, info);
                break;
            case PlayerState.flipped:
                action = new FlippedMovement(gameObject);
                break;
        }
    }
}

public enum PlayerState
{
    normal,
    flipped
}