using UnityEngine;

namespace Managers
{
    public class CalendarManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            EventManager.NextCycleEvent += PopupOnNextCycle;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void PopupOnNextCycle()
        {
            // TODO; continue here
            //WindowManager.I.
        }
    }
}
