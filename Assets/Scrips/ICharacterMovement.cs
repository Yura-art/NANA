using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovementSystem
{

    public float Speed { get; set; }
    public void Move(Transform characterT);
    public void SetTarget(Transform target);
    public void SetSpeed(float speed)
    {
        Speed = speed;
    }

}
