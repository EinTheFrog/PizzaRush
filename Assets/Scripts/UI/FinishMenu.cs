using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishMenu : MonoBehaviour
{
    [SerializeField] private TimeInfoText timeInfoText;

    public void Open(float finishTime)
    {
        timeInfoText.SetTime(finishTime);
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public bool isActive()
    {
        return gameObject.activeInHierarchy;
    }
}
