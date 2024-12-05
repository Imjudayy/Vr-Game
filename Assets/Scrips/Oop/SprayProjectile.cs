using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayProjectile : Projectile
{
   
        
        protected override void Start()
        {
            speed = 1f;  
            base.Start();  
        }

        protected override void OnCollisionEnter(Collision other)
        {
            base.OnCollisionEnter(other);
            
        }
    

}
