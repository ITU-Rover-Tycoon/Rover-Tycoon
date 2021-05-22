using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using UnityEngine;

public class RoverStatistics : MonoBehaviour
{
    [SerializeField] private GameObject selectedPanel;
    public static List<GameObject> panelslist = new List<GameObject>(); // Curretnly active windows

    public static void Fill_panels_list(GameObject new_panel)
    {
        panelslist.Add(new_panel);
    }

    public static void closeAllPanels()
    {
        for (int a = 0; a < panelslist.Count; a++)
        { 
            panelslist[a].SetActive(false);
        }
        panelslist = new List<GameObject>();
        Debug.Log(panelslist.Count);
    }
}
