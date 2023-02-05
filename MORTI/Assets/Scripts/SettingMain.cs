using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingMain : MonoBehaviour
{
    public bool settings;
    public bool navMode;
    public bool missionProtocol;
    public bool vitals;
    public void goingToMain()
    {
        settings = false;
        navMode = false;
        missionProtocol = false;
        vitals = false;
        Debug.Log("Going to Main Menu");



    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
