using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameGunControls : MonoBehaviour
{
    public GameObject FirePrefab;
    public Transform barrelPos;
    public AudioClip FireSfx;
    public ParticleSystem FireFx;
    private AudioSource _audioSourve;

    private void Start()
    {
        _audioSourve = GetComponent<AudioSource>();
    }


    public void Shoot()
    {
        Instantiate(FirePrefab, barrelPos.position, barrelPos.rotation);
        _audioSourve.PlayOneShot(FireSfx, 1f);
        FireFx.Play();
        print("Shoot!");
    }
}
