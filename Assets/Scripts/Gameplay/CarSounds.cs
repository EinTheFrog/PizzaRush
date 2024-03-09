using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSounds : MonoBehaviour
{
    [SerializeField] private AudioSource startup;
    [SerializeField] private AudioSource lowSpeed;
    [SerializeField] private AudioSource highSpeed;
    [SerializeField] private float highSpeedValue = 20f;

    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        startup.Play();
        lowSpeed.loop = true;
        highSpeed.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsHighSpeed())
        {
            PlayHighSpeedSound();
        } else
        {
            PlayLowSpeedSound();
        }
    }

    private bool IsHighSpeed()
    {
        return _rigidbody.velocity.magnitude > highSpeedValue;
    }

    private void PlayLowSpeedSound()
    {
        if (!lowSpeed.isPlaying)
        {
            lowSpeed.Play();
        }
        highSpeed.Stop();
    }

    private void PlayHighSpeedSound()
    {
        if (!highSpeed.isPlaying)
        {
            highSpeed.Play();
        }
        lowSpeed.Stop();
    }  
}
