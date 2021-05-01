using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Window : MonoBehaviour
{
    private GameObject subwindow; 
    // Start is called before the first frame update
    void Start()
    {
        // add yourself to WindowManager
        // if unsuccessful, throw exception
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Exit()
    {
        
    }

    public void Info()
    {
        
    }

    public void ToggleActivation()
    {
        subwindow.SetActive(!subwindow.activeSelf);
    }
}
