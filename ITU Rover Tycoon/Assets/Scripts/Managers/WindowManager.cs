using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UIElements;

namespace Managers
{
    public class WindowManager : Singleton<WindowManager>
    {
        public List<Window> windows_list = new List<Window>(); // Curretnly active windows
        
        // Start is called before the first frame update
        void Start()
        {
            
        }

        public void Fill_windows_list(Window new_window)
        {
            windows_list.Add(new_window);
            Debug.Log(windows_list.Count);
        }
        public void Pop(Window new_window)
        {
            windows_list.RemoveAt(windows_list.IndexOf(new_window));
            Debug.Log(windows_list.Count);
        }

        public void CloseAllWindows()
        {
            for (int a = 0; a < windows_list.Count; a++)
            {
                windows_list[a].gameObject.SetActive(false);
            }
            windows_list = new List<Window>(); // Clear bakilacak
        }
    }
}
