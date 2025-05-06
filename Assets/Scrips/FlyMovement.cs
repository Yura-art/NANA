using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMovement : MonoBehaviour, IMovementSystem
{
    Transform target;
    private float speed;
    public float Speed => speed;

    public void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position,speed * Time.deltaTime);
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }
}
