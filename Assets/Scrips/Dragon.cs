using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dragon : Character
{

    [SerializeField] float speed;
    [SerializeField] Transform target;

    private void Awake()
    {
        FlyMovement fly = new FlyMovement();
        fly.Speed = speed;

        Initializedcharacter(fly);
    }

    private void Start()
    {
        movement.SetTarget(target);
    }
}

