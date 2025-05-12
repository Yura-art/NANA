using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected IMovementSystem movement;
    protected IAttackSystem attack;

    public void Initializedcharacter(IMovementSystem movementSystem, IAttackSystem attackSystem)
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