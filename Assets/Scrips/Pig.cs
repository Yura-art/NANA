using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class Pig : Character
{
    [SerializeField] Transform pivot;
    [SerializeField] GameObject power;
    [SerializeField] float speed;
    [SerializeField] Transform target;
    [SerializeField] NavMeshAgent Nav;
    private void Awake()
    {
        GroundMovement ground = new GroundMovement(Nav);
        ground.Speed = speed;

        Initializedcharacter(ground, new RangeAttackSystem(pivot, power));
    }
    private void Start()
    {
        movement.SetTarget(target);
    }


}