using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelemetryTest : MonoBehaviour
{
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TelemetryLIB.startSim());
        
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if(count == 60)
        {
            StartCoroutine(TelemetryLIB.getData());
            count = 0;
        }
        
    }
}
