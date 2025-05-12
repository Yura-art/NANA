using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dragon : Character
{
    [SerializeField] Transform pivot;
    [SerializeField] GameObject power;
    [SerializeField] float speed;
    [SerializeField] Transform target;

    private void Awake()
    {
        FlyMovement fly = new FlyMovement();
        fly.Speed = speed;

        Initializedcharacter(fly, new RangeAttackSystem(pivot , power));
    }

    private void Start()
    {
        movement.SetTarget(target);
    }
}

