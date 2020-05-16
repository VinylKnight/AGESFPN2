using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayTime : MonoBehaviour
{    
    private Text elapsedTime;
    private void Awake()
    {
        elapsedTime = GetComponent<Text>();

    }
    // Update is called once per frame
    void Update()
    {
        elapsedTime.text = Time.time.ToString("f1");
    }
}
