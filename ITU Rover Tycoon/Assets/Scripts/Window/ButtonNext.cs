using System.Collections;
using System.Collections.Generic;
using Managers;
using UnityEngine;

public class ButtonNext : MonoBehaviour
{
    public void ButtonPressed()
    {
        if (WindowManager.I.focusOverriden)
        {
            WindowManager.I.CloseAllWindows();
            return;
        }
        GameManager.I.events.TriggerNextCycle();
    }
}
