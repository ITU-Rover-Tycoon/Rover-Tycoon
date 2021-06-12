using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Managers;
using UnityEngine;



public class Window : MonoBehaviour
{
    [SerializeField] public GameObject subwindow;
    void Awake()
    {
        subwindow = gameObject;
        // add yourself to WindowManager
        // if unsuccessful, throw exception
    }


    public void ToggleActivation()
    {
        
        if (subwindow.activeSelf)
        {
            Exit();
        }
        else
        {
            Open();
        }
    }
    
    public void Exit()
    {
        subwindow.SetActive(false);
        WindowManager.I.PopActiveWindow(this);
    }

    public void Info()
    {
        
    }

    private void Open()
    {
        WindowManager.I.CloseAllWindows();
        subwindow.SetActive(true);
        WindowManager.I.AddActiveWindow(this);
    }
}
