using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{

    public float spped = 40f;
    public float lifeTime = 1.2f;

    private SocreManager _scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        
        Rigidbody rb = GetComponent<Rigidbody>();
        _scoreManager = FindObjectOfType<SocreManager>();
        rb.velocity = transform.forward * spped;
        
        Destroy(gameObject,lifeTime);

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Target"))
        {
            _scoreManager.score += 1;
            Destroy(other.gameObject, 0.2f);
            Destroy(gameObject);
        }
    }

}
