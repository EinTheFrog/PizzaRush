using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] LevelManager levelManager;

    private void OnTriggerEnter(Collider other)
    {
        levelManager.OnCheckpointEnter();
    }
}
