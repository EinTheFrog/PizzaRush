using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeInfoText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public void SetTime(float time)
    {
        text.SetText("Time: " + time.ToString("0.00"));
    }
}
