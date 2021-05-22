using UnityEngine;
using UnityEngine.SceneManagement;

namespace ScriptsLibrary
{
    public static class SceneLoader
    {

        public enum Scenes
        {
            Core,
            MainMenu,
            GameScene,
        }

        public static void Load(Scenes scenes)
        {
            SceneManager.LoadScene(scenes.ToString());
        }
    }
    
}





