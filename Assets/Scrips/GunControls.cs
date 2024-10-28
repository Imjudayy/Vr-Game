using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControls : MonoBehaviour
{

    public GameObject bullerPrefab;
    public Transform barrelPos;
    public AudioClip gunSfx;
    public ParticleSystem gunFx;
    private AudioSource _audioSourve;

    private void Start()
    {
        _audioSourve = GetComponent<AudioSource>();
    }


    public void Shoot()
    {
        Instantiate(bullerPrefab, barrelPos.position, barrelPos.rotation);
        _audioSourve.PlayOneShot(gunSfx, 1f);
        gunFx.Play();
        print("Shoot!");
    }



}
