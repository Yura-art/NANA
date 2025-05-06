using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected IMovementSystem movement;

    public void Initializedcharacter(IMovementSystem movementSystem)
    {
        movement = movementSystem;
    }

    private void Update()
    {

        if (movement != null)
        {
            movement.Move(transform);

        }
    }
}
