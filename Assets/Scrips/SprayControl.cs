using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayControl : MonoBehaviour
{
    public GameObject MistPrefab;
    public Transform barrelPos;
    public AudioClip SpraySfx;
    public ParticleSystem SprayFx;
    private AudioSource _audioSourve;

    private void Start()
    {
        _audioSourve = GetComponent<AudioSource>();
    }


    public void Shoot()
    {
        Instantiate(MistPrefab, barrelPos.position, barrelPos.rotation);
        _audioSourve.PlayOneShot(SpraySfx, 1f);
        SprayFx.Play();
        print("Shoot!");
    }
}
