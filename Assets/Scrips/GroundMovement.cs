using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GroundMovement : IMovementSystem
{
    [SerializeField] private float speed;
    [SerializeField] Transform target;
    [SerializeField] NavMeshAgent agent;

    public float Speed { get => Speed; set => Speed = value; }

    public  GroundMovement(NavMeshAgent agent)
    {
        this.agent = agent;
    }
    public void Move(Transform characterT)
    {

        agent.SetDestination(target.position);

    }

    public void SetTarget(Transform target)
    {

        this.target = target;

    }
}
