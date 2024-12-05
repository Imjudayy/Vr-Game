using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameProjectile : Projectile
{


   
        
        protected override void Start()
        {
            speed = 3f;  
            base.Start();  
        }

        protected override void OnCollisionEnter(Collision other)
        {
            base.OnCollisionEnter(other);
            
        }
    }



