using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class Pig :Character
{
    [SerializeField] float speed;
    [SerializeField] Transform target;
    [SerializeField] NavMeshAgent agent;

    private void Awake()
    {
        GroundMovement ground = new GroundMovement(agent);
        ground.Speed = speed;   

        Initializedcharacter(ground);
    }

    private void Start()
    {
        movement.SetTarget(target);
    }
}
