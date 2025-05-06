using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    IMovementSystem movement;

    public void InitializeCharacter

    private void Update()
    {
        if (movement == null)
        {
            movement.Move(transform);
        }
       
    }
}
