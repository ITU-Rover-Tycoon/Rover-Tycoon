using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptsLibrary;


namespace Managers
{
    public class GameManager : Singleton<GameManager>
    {
        public delegate void NextCycleHandler();
        public delegate void PauseBeginHandler();
        public delegate void PauseEndHandler();
        public delegate void GameStartHandler();
        
        public static event NextCycleHandler NextCycleEvent;
        public static event PauseBeginHandler PauseBeginEvent;
        public static event PauseEndHandler PauseEndEvent;
        public static event GameStartHandler GameStartEvent;
        
        void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }

        private void GoToNextCycle()
        {
            NextCycleEvent?.Invoke();
        }

        private void PauseBegin()
        {
            PauseBeginEvent?.Invoke();
        }
        
        private void PauseEnd()
        {
            PauseEndEvent?.Invoke();
        }
        
        private void GameStart()
        {
            GameStartEvent?.Invoke();
        }
        
    }
}