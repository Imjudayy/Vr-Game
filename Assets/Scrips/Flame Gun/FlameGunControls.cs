using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameGunControls : MonoBehaviour
{
    public GameObject FirePrefab;
    public Transform barrelPos;
    public AudioClip FireSfx;
    public ParticleSystem FireFx;
    public float fireInterval;
    private AudioSource _audioSourve;

    private bool isShooting;
    private float fireTimer;

    private void Start()
    {
        _audioSourve = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (isShooting && fireTimer <= 0)
        {
            Shoot();
            fireTimer = fireInterval;
        }
        fireTimer -= Time.deltaTime;
    }


    public void Shoot()
    {
        Instantiate(FirePrefab, barrelPos.position, barrelPos.rotation);
        _audioSourve.PlayOneShot(FireSfx, 1f);
        
        print("Shoot!");
    }

    public void OnDeactivate()
    {
        FireFx.Stop();
        isShooting = false;
    }

    public void OnActivate()
    {
        FireFx.Play();
        isShooting = true;
    }
}
