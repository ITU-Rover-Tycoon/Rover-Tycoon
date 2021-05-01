using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPress(string buttonName) // burası windowEnum da olacak
    {
        switch (buttonName)
        {
            case "Finance":
            case "Calendar":
                ToggleWindow(buttonName);
                break;
        }
    }

    private void ToggleWindow(string windowName)
    {
        
    }
}
