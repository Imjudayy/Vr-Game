using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayProjectile : Projectile
{
    protected override void Start()
    {
        Speed = 1f;  
        LifeTime = 0.2f; 
        base.Start();
    }

    protected override void OnCollisionEnter(Collision other)
    {
        base.OnCollisionEnter(other);
        
    }
}
