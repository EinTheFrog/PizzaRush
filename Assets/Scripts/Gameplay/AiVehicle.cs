using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiVehicle : MonoBehaviour
{
    [SerializeField] private AiCheckpoint[] checkpoints;
    [SerializeField] private string aiCheckpointTag;

    private NavMeshAgent agent;
    private int currentCheckpointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetCheckpointDestination(checkpoints[currentCheckpointIndex]);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(aiCheckpointTag))
        {
            UpdateDestination();
        }
    }

    private void UpdateDestination()
    {
        NextCheckpointIndex();
        SetCheckpointDestination(checkpoints[currentCheckpointIndex]);
    }

    private void NextCheckpointIndex()
    {
        if (currentCheckpointIndex == checkpoints.Length - 1)
        {
            currentCheckpointIndex = 0;
        } else
        {
            currentCheckpointIndex++;
        }
    }

    private void SetCheckpointDestination(AiCheckpoint checkpoint)
    {
        agent.SetDestination(checkpoint.gameObject.transform.position);
    }
}
