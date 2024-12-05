using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameProjectile : Projectile
{
    protected override void Start()
    {
        Speed = 3f;  
        LifeTime = 0.5f; 
        base.Start();
    }

    protected override void OnCollisionEnter(Collision other)
    {
        base.OnCollisionEnter(other);
        
    }
}
