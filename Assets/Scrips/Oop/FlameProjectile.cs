using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameProjectile : Projectile
{
  /*  public override void Start()
    {
        speed = 3f;  // ความเร็วของกระสุน FlameGun
        base.Start();
    }

    protected override void OnCollisionEnter(Collision other)
    {
        base.OnCollisionEnter(other);
        // เพิ่มคะแนนสำหรับการชนกับเป้าหมายของ FlameGun (Mouse หรือ Cockroach)
    }

*/

   
        // ทำให้ Start() เป็น protected ตามคลาสฐาน
        protected override void Start()
        {
            speed = 3f;  // ความเร็วของกระสุน FlameGun
            base.Start();  // เรียกใช้ Start() ของคลาสฐาน
        }

        protected override void OnCollisionEnter(Collision other)
        {
            base.OnCollisionEnter(other);
            // เพิ่มคะแนนสำหรับการชนกับเป้าหมายของ FlameGun (Mouse หรือ Cockroach)
        }
    }



