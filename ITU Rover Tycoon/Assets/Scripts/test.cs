using System.Collections;
using System.Collections.Generic;
using Managers;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventManager.NextCycleEvent += NextCycleTest;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NextCycleTest()
    {
        
    }
}
