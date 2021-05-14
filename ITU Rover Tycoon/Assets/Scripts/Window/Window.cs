using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Window : MonoBehaviour
{
    [SerializeField] private GameObject subwindow;
    // Start is called before the first frame update
    void Awake()
    {
        subwindow = gameObject; 
        // add yourself to WindowManager
        // if unsuccessful, throw exception
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Exit()
    {
        subwindow.SetActive(false);
    }

    public void Info()
    {
        
    }

    public void ToggleActivation()
    {
        subwindow.SetActive(!subwindow.activeSelf);
    }
}
