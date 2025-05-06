using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public interface IMovementSystem
{
    public float Speed { get; set; }
    public void Move(Transform characterT);
    public void SetTarget(Transform target);
    

}   
