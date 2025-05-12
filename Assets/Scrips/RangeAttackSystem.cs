using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeAttackSystem : IAttackSystem
{

    Transform pivot;
    GameObject power;

    public RangeAttackSystem(Transform pivot, GameObject power)
    {
        this.pivot = pivot;
        this.power = power;
    }
    public void Attack()
    {

    }
}