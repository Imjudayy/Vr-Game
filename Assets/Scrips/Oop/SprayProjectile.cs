using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayProjectile : Projectile
{
   /* public override void Start()
    {
        speed = 1f;  // �������Ǣͧ����ع Spray
        base.Start();
    }

    protected override void OnCollisionEnter(Collision other)
    {
        base.OnCollisionEnter(other);
        // ������ṹ����Ѻ��ê��Ѻ������¢ͧ Spray (Mouse ���� Cockroach)
    }*/




   
  
        // ����� Start() �� protected ������ʰҹ
        protected override void Start()
        {
            speed = 1f;  // �������Ǣͧ����ع Spray
            base.Start();  // ���¡�� Start() �ͧ���ʰҹ
        }

        protected override void OnCollisionEnter(Collision other)
        {
            base.OnCollisionEnter(other);
            // ������ṹ����Ѻ��ê��Ѻ������¢ͧ Spray (Mouse ���� Cockroach)
        }
    

}
