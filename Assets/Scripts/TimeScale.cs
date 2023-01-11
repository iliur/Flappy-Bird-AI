using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScale : MonoBehaviour
{
    public float timeScaling;
    // Update is called once per frame
    void Update()
    {
        Time.timeScale = timeScaling;
    }
}
