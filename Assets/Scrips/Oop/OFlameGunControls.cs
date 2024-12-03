using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class OFlameGunControls : Weapon
{
    public GameObject firePrefab; // GameObject ����繡���ع�ͧ�׹�
    public float fireInterval = 0.2f; // ��������㹡���ԧ���駶Ѵ�
    private float fireTimer;

    private bool isShooting;

    private void Update()
    {
        // �礡���ԧ�ء���駷�� fireTimer �֧ 0
        if (isShooting && fireTimer <= 0)
        {
            Shoot();
            fireTimer = fireInterval; // ��������
        }

        fireTimer -= Time.deltaTime; // Ŵ���� fireTimer ŧ�ء���
    }

    public override void Shoot()
    {
        // ���ҧ����ع����ҡ firePrefab
        GameObject projectile = Instantiate(firePrefab, barrelPos.position, barrelPos.rotation);

        // ��˹��������Ǣͧ����ع (㹡óչ����������Ƿ���٧���)
        FlameProjectile flameProjectile = projectile.GetComponent<FlameProjectile>();
        flameProjectile.speed = 3f;  // �������Ƿ���ͧ�������Ѻ�׹�

        // ������§����Ϳ�硵�
        PlaySound();
        PlayEffect();

        print("Flame Gun Shot!");
    }

    public void OnActivate()
    {
        // ���������ԧ����ͻ׹�١�Դ��ҹ
        fireFx.Play();
        isShooting = true;
    }

    public void OnDeactivate()
    {
        // ��ش����ԧ����ͻ׹�١�Դ
        fireFx.Stop();
        isShooting = false;
    }
}
