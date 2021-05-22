using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptsLibrary;

namespace Managers
{
    public class GameManager : Singleton<GameManager>
    {
        [SerializeField] private SceneLoader.Scenes startScenes;
        [SerializeField] private bool loadStartScene;

        public int cycleIndex = 0;

        public EventManager events;

        void Awake()
        {
            // DontDestroyOnLoad(this.gameObject);
        }

        private void Start()
        {
            if (loadStartScene && (startScenes != SceneLoader.Scenes.Core)) SceneLoader.Load(startScenes);
            EventManager.NextCycleEvent += NextCycleActions;
            events = GetComponent<EventManager>();
            
        }


        private void NextCycleActions()
        {
            cycleIndex += 1;
            Debug.Log("The current cycle index is" + cycleIndex);
        }
    }
}