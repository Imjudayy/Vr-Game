using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
 


   
        public float speed;
        public float lifeTime = 0.1f;

        
        protected virtual void Start()
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = transform.forward * speed;

            Destroy(gameObject, lifeTime);
        }

        protected virtual void OnCollisionEnter(Collision other)
        {
            
        }
    }

