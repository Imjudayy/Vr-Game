using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Weapon : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform barrelPos;
    public AudioClip fireSfx;
    public ParticleSystem fireFx;

    protected AudioSource _audioSource;

    protected virtual void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Abstract Method สำหรับการยิง
    public abstract void Shoot();

    protected void PlaySound()
    {
        _audioSource.PlayOneShot(fireSfx, 1f);
    }

    protected void PlayEffect()
    {
        fireFx.Play();
    }
}