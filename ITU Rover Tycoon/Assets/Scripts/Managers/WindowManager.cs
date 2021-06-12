using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UIElements;

namespace Managers
{
    public class WindowManager : Singleton<WindowManager>
    {
        public List<Window> activeWindows = new List<Window>(); // Curretnly active windows
        public bool focusOverriden = false;

        
        public void AddActiveWindow(Window new_window)
        {
            focusOverriden = true;
            activeWindows.Add(new_window);
        }
        public void PopActiveWindow(Window new_window)
        {
            // TODO;
            // This should work the same way. try it and if this is better, change with this. Delete old.
            // Reason: easier to read
            // windows_list.Remove(new_window);
            
            activeWindows.RemoveAt(activeWindows.IndexOf(new_window));
            focusOverriden = (activeWindows.Count != 0);
        }

        public void CloseAllWindows()
        {
            //  Creating a new list so that we don't fiddle with the list during foreach.
            List<Window>  activeWindowsBuffer = new List<Window>(activeWindows) ;
            foreach (var window in activeWindowsBuffer)
            {
                window.Exit();
            }

            focusOverriden = false;
        }
    }
}
