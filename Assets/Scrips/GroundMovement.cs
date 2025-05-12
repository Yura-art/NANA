using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GroundMovement : IMovementSystem
{

    NavMeshAgent Nav;
    private float speed;
    Transform target;


    public GroundMovement(NavMeshAgent agent)
    {

    }

    public float Speed { get => speed; set => speed = value; }

    public void Move(Transform characterT)
    {

    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }
}
