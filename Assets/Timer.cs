using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time;                            //gjorde en float så jag behövde skriva mindre
        string minutes = ((int)t / 60).ToString();      // räknar ut hur många minuter som har gått
        string seconds = (t % 60).ToString("f2");       // räknar ut hur många sekunder som har gått
        Debug.Log("Timer:" + minutes + ":" + seconds);  // printar bar ut vad timern är
    }
}
