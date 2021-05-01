using UnityEngine;

namespace ScriptsLibrary
{
    public class InventoryLibrary : MonoBehaviour
    {
       
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public class Item
        {

            public int number = 2;
            public static void printItem()
            {
                Debug.Log("printed item");
            }
        }
    }
}
