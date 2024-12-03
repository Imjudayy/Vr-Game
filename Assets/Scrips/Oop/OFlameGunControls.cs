using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class OFlameGunControls : Weapon
{
    public GameObject firePrefab; // GameObject ที่เป็นกระสุนของปืนไฟ
    public float fireInterval = 0.2f; // ระยะเวลาในการยิงครั้งถัดไป
    private float fireTimer;

    private bool isShooting;

    private void Update()
    {
        // เช็คการยิงทุกครั้งที่ fireTimer ถึง 0
        if (isShooting && fireTimer <= 0)
        {
            Shoot();
            fireTimer = fireInterval; // รีเซ็ตเวลา
        }

        fireTimer -= Time.deltaTime; // ลดเวลา fireTimer ลงทุกเฟรม
    }

    public override void Shoot()
    {
        // สร้างกระสุนใหม่จาก firePrefab
        GameObject projectile = Instantiate(firePrefab, barrelPos.position, barrelPos.rotation);

        // กำหนดความเร็วของกระสุน (ในกรณีนี้ใช้ความเร็วที่สูงขึ้น)
        FlameProjectile flameProjectile = projectile.GetComponent<FlameProjectile>();
        flameProjectile.speed = 3f;  // ความเร็วที่ต้องการสำหรับปืนไฟ

        // เล่นเสียงและเอฟเฟ็กต์
        PlaySound();
        PlayEffect();

        print("Flame Gun Shot!");
    }

    public void OnActivate()
    {
        // เริ่มการยิงเมื่อปืนถูกเปิดใช้งาน
        fireFx.Play();
        isShooting = true;
    }

    public void OnDeactivate()
    {
        // หยุดการยิงเมื่อปืนถูกปิด
        fireFx.Stop();
        isShooting = false;
    }
}
