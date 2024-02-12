using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTrap : MonoBehaviour
{
    [SerializeField] GameObject car;
    [SerializeField] float force;
    [SerializeField] string playerTag;

    private Rigidbody carRigidbody;
    private Transform carTransform;

    private void Start()
    {
        carRigidbody = car.GetComponent<Rigidbody>();
        carTransform = car.transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals(playerTag))
        {
            Debug.Log("Player entered");
            ActivateTrap();
        }
    }

    private void ActivateTrap()
    {
        carRigidbody.AddForce(-carTransform.forward * force, ForceMode.Impulse);
    }
}
