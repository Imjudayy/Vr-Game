using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameProjectile : Projectile
{
  /*  public override void Start()
    {
        speed = 3f;  // �������Ǣͧ����ع FlameGun
        base.Start();
    }

    protected override void OnCollisionEnter(Collision other)
    {
        base.OnCollisionEnter(other);
        // ������ṹ����Ѻ��ê��Ѻ������¢ͧ FlameGun (Mouse ���� Cockroach)
    }

*/

   
        // ����� Start() �� protected ������ʰҹ
        protected override void Start()
        {
            speed = 3f;  // �������Ǣͧ����ع FlameGun
            base.Start();  // ���¡�� Start() �ͧ���ʰҹ
        }

        protected override void OnCollisionEnter(Collision other)
        {
            base.OnCollisionEnter(other);
            // ������ṹ����Ѻ��ê��Ѻ������¢ͧ FlameGun (Mouse ���� Cockroach)
        }
    }



