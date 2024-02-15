using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] LevelManager levelManager;
    [SerializeField] string playerTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals(playerTag))
        {
            levelManager.OnCheckpointEnter();
        }
    }
}
