using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    
    public delegate void NextCycleHandler();
    public delegate void PauseBeginHandler();
    public delegate void PauseEndHandler();
    public delegate void GameStartHandler();
    
    public static event NextCycleHandler NextCycleEvent;
    public static event PauseBeginHandler PauseBeginEvent;
    public static event PauseEndHandler PauseEndEvent;
    public static event GameStartHandler GameStartEvent;
    
    public void TriggerNextCycle()
    {
        NextCycleEvent?.Invoke();
    }

    public void TriggerPauseBegin()
    {
        PauseBeginEvent?.Invoke();
    }
        
    public void TriggerPauseEnd()
    {
        PauseEndEvent?.Invoke();
    }
        
    public void TriggerGameStart()
    {
        GameStartEvent?.Invoke();
    }
}
