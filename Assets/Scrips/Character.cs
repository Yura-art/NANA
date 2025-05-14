using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected IMovementSystem movement;
    protected IAttackSystem attack;
    protected ITransformable transformable;

    public void Initializedcharacter(IMovementSystem movementSystem, IAttackSystem attackSystem, ITransformable transformableSystem)
    {
        movement = movementSystem;
        attack = attackSystem;
        transformable = transformableSystem;
    }

    private void Update()
    {

        if (movement != null)
        {
            movement.Move(transform);

        }


        if (Input.GetKeyDown(KeyCode.Space)) 
        {


            transformable.Transform();
        
        }

    }
}