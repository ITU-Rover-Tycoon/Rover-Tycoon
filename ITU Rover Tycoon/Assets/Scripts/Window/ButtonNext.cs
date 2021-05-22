using System.Collections;
using System.Collections.Generic;
using Managers;
using UnityEngine;

public class ButtonNext : MonoBehaviour
{
    public void ButtonPressed()
    {
        GameManager.I.events.TriggerNextCycle();
    }
}
