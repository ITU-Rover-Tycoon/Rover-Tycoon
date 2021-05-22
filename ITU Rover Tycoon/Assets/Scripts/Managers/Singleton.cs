using UnityEngine;

namespace Managers
{
    
[DisallowMultipleComponent]
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T i;
    public static T I
    {
        get
        {
            if (i == null) i = (T) FindObjectOfType(typeof(T));
            else
            {
                Debug.Log("Singleton error: more than one instance of a singleton was created." +
                          " Might fuck stuff up");
            }
            return i;
        }
    }
}

}