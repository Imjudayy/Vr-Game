using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayProjectile : Projectile
{
   /* public override void Start()
    {
        speed = 1f;  // ความเร็วของกระสุน Spray
        base.Start();
    }

    protected override void OnCollisionEnter(Collision other)
    {
        base.OnCollisionEnter(other);
        // เพิ่มคะแนนสำหรับการชนกับเป้าหมายของ Spray (Mouse หรือ Cockroach)
    }*/




   
  
        // ทำให้ Start() เป็น protected ตามคลาสฐาน
        protected override void Start()
        {
            speed = 1f;  // ความเร็วของกระสุน Spray
            base.Start();  // เรียกใช้ Start() ของคลาสฐาน
        }

        protected override void OnCollisionEnter(Collision other)
        {
            base.OnCollisionEnter(other);
            // เพิ่มคะแนนสำหรับการชนกับเป้าหมายของ Spray (Mouse หรือ Cockroach)
        }
    

}
