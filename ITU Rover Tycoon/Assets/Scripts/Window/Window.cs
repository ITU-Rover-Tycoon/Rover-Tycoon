using System;
using System.Collections;
using System.Collections.Generic;
using Managers;
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
        WindowManager.I.Pop(this);
    }

    public void Info()
    {
        
    }

    public void ToggleActivation()
    {

        if (!subwindow.activeSelf)
        {
            WindowManager.I.CloseAllWindows();
            WindowManager.I.Fill_windows_list(this);
        }
        else
        {
            //WindowManager.I.Pop(this);
            Debug.Log("Fuck u");
        }
        
        subwindow.SetActive(!subwindow.activeSelf);
    }
}
