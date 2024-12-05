using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    private float speed;
    private float lifeTime = 0.1f;

   
    public float Speed
    {
        get => speed;
        set
        {
            if (value > 0) 
                speed = value;
        }
    }

    public float LifeTime
    {
        get => lifeTime;
        set
        {
            if (value > 0)
                lifeTime = value;
        }
    }

    protected virtual void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * Speed;

        Destroy(gameObject, LifeTime);
    }

    protected virtual void OnCollisionEnter(Collision other)
    {
        
    }
}
