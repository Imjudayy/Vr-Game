using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class OFlameGunControls : Weapon
{
    public GameObject firePrefab;
    public float fireInterval = 0.2f; 
    private float fireTimer;

    private bool isShooting;

    private void Update()
    {
        
        if (isShooting && fireTimer <= 0)
        {
            Shoot();
            fireTimer = fireInterval; 
        }

        fireTimer -= Time.deltaTime; 
    }

    public override void Shoot()
    {
        
        GameObject projectile = Instantiate(firePrefab, barrelPos.position, barrelPos.rotation);

        
        FlameProjectile flameProjectile = projectile.GetComponent<FlameProjectile>();
        flameProjectile.Speed = 3f;  

        
        PlaySound();
        PlayEffect();

        print("Flame Gun Shot!");
    }

    public void OnActivate()
    {
        
        fireFx.Play();
        isShooting = true;
    }

    public void OnDeactivate()
    {
        
        fireFx.Stop();
        isShooting = false;
    }
}
