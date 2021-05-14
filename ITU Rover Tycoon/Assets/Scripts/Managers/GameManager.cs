using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptsLibrary;



namespace Managers
{
    
    
    public class GameManager : Singleton<GameManager>
    {
        public delegate void NextCycleHandler();
        public static event NextCycleHandler NextCycle;
        
        public delegate void PauseBeginHandler();
        public static event PauseBeginHandler PauseBegin;
        
        public delegate void PauseEndHandler();
        public static event PauseEndHandler PauseEnd;

        public delegate void GameStartHandler();

        public static event GameStartHandler GameStart;
        
        void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }




        private void GoToNextCycle()
        {
            NextCycle?.Invoke();
        }
        


    }
}