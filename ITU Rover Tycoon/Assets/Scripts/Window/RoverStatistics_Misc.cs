using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverStatistics_Misc : MonoBehaviour
{
    [SerializeField] private GameObject selectedPanel;
    public void TogglePanel()

    {
        if (!selectedPanel.activeSelf)
        {
            RoverStatistics.closeAllPanels();
            RoverStatistics.Fill_panels_list(this.gameObject);
        }
        else
        {
            //Pop(this);
            Debug.Log("Fuck");
        }
        
        selectedPanel.SetActive(!selectedPanel.activeSelf);
    }
}
