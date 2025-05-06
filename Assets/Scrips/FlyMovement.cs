using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMovement : IMovementSystem
{

    [SerializeField] Transform target;

    private float speed;

    public float Speed { get => speed; set => speed = value; }

    public void Move(Transform characterT)
    {

        if (target != null)
        {
            characterT.position = Vector3.MoveTowards(characterT.position, target.position, Speed * Time.deltaTime);

        }
    }

    public void SetTarget(Transform target)
    {

        this.target = target;
    }
}
