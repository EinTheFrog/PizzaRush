using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    public void SetTime(float time)
    {
        text.SetText("Time: " + time.ToString("0.00"));
    }
}
