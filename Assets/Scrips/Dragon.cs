using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Character
{

    [SerializeField] Transform target;

    private void Awake()
    {
        Initializedcharacter(new FlyMovement());
    }

    private void Start()
    {
        movement.SetTarget(target);
    }
}

