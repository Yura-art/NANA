
using UnityEngine;

public interface IMovementSystem
    
{
    public float Speed {  get; }
    public void SetTarget(Transform target);
    public void Move(); 
}
