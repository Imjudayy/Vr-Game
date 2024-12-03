using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSprayControl : Weapon
{
    /*public GameObject MistPrefab;

    public override void Shoot()
    {
        Instantiate(MistPrefab, barrelPos.position, barrelPos.rotation);
        PlaySound();
        PlayEffect();
        print("Spray Shot!");
    }*/


    public GameObject mistPrefab;

    public override void Shoot()
    {
        GameObject projectile = Instantiate(mistPrefab, barrelPos.position, barrelPos.rotation);
        SprayProjectile sprayProjectile = projectile.GetComponent<SprayProjectile>();
        sprayProjectile.speed = 1f; // ความเร็วที่ต้องการ
        PlaySound();
        PlayEffect();
        print("Spray Shot!");
    }


}
