using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptsLibrary;



namespace Managers
{
    
    public class GameManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int c;
            c = (int) MembersManager.MyEnum.abc;
            
            Debug.Log("printing c");
            Debug.Log(c.ToString());
            InventoryLibrary.Item.printItem();
            InventoryLibrary.Item a;
            DontDestroyOnLoad(this.gameObject);
            DontDestroyOnLoad(this.gameObject);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}