using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameGunControls : MonoBehaviour
{

    #region Old code
    /*public GameObject FirePrefab;
    public Transform barrelPos;
    public AudioClip FireSfx;
    public ParticleSystem FireFx;
    public float fireInterval;
    private AudioSource _audioSourve;

    private bool isShooting;
    private float fireTimer;

    private void Start()
    {
        _audioSourve = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (isShooting && fireTimer <= 0)
        {
            Shoot();
            fireTimer = fireInterval;
        }
        fireTimer -= Time.deltaTime;
    }


    public void Shoot()
    {
        Instantiate(FirePrefab, barrelPos.position, barrelPos.rotation);
        _audioSourve.PlayOneShot(FireSfx, 1f);
        
        print("Shoot!");
    }

    public void OnDeactivate()
    {
        
        FireFx.Stop();
        isShooting = false;
        _audioSourve.Stop();
    }

    public void OnActivate()
    {
        
        FireFx.Play();
        isShooting = true;
    }*/
    #endregion

    //new

    public GameObject FirePrefab;
    public Transform barrelPos;
    public AudioClip FireSfx;
    public ParticleSystem FireFx;
    public float fireInterval;
    public float soundStopDelay = 0.5f; // ����˹�ǧ��͹�����Ŵ���§
    public float fadeOutDuration = 1f; // ��������㹡��Ŵ���§
    private AudioSource _audioSource;

    private bool isShooting;
    private float fireTimer;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (isShooting && fireTimer <= 0)
        {
            Shoot();
            fireTimer = fireInterval;
        }
        fireTimer -= Time.deltaTime;
    }

    public void Shoot()
    {
        Instantiate(FirePrefab, barrelPos.position, barrelPos.rotation);
        _audioSource.PlayOneShot(FireSfx, 1f);

        print("Shoot!");
    }

    public void OnDeactivate()
    {
        FireFx.Stop();
        isShooting = false;

        // ���¡ Coroutine ������ش���§��ѧ�ҡ��������Ф���� Ŵ���§
        StartCoroutine(FadeOutSound());
    }

    private IEnumerator FadeOutSound()
    {
        yield return new WaitForSeconds(soundStopDelay); // ˹�ǧ���ҵ������˹�

        float startVolume = _audioSource.volume;

        while (_audioSource.volume > 0)
        {
            _audioSource.volume -= startVolume * Time.deltaTime / fadeOutDuration;
            yield return null;
        }

        _audioSource.Stop();
        _audioSource.volume = startVolume; // �����дѺ���§��Ѻ����ѧ�ҡ��ش���§
    }

    public void OnActivate()
    {
        FireFx.Play();
        isShooting = true;
    }
}
