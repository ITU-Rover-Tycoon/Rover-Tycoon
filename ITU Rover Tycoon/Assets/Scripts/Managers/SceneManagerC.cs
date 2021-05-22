using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using ScriptsLibrary;

namespace Managers
{
    public class SceneManagerC : MonoBehaviour
    {
        [SerializeField] private SceneLoader.Scenes startScenes;
        // Start is called before the first frame update
        void Start()
        {
            Load(startScenes);
        }


        void Load(SceneLoader.Scenes scenes)
        {
            SceneManager.LoadScene(scenes.ToString());
        }
    }
}
