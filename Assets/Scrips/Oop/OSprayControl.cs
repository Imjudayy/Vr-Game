using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSprayControl : Weapon
{
   

    public GameObject mistPrefab;

    public override void Shoot()
    {
        GameObject projectile = Instantiate(mistPrefab, barrelPos.position, barrelPos.rotation);
        SprayProjectile sprayProjectile = projectile.GetComponent<SprayProjectile>();
        sprayProjectile.Speed = 1f; 
        PlaySound();
        PlayEffect();
        print("Spray Shot!");
    }


}
