using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class PlayerInventory : MonoBehaviour
{
    //public SO_Item[] inventoryItems;
    public List<SO_Item> inventoryItems = new List<SO_Item>();

    private void Update()
    {
        if (inventoryItems.Count > 0)
        {
            int value = -1;
            for (int i = 0; i <= 9; i++)
            {
                KeyCode main = (KeyCode)((int)KeyCode.Alpha0 + i);
                KeyCode pad = (KeyCode)((int)KeyCode.Keypad0 + i);

                if (Input.GetKeyDown(main) || Input.GetKeyDown(pad))
                {
                    value = i;
                    inventoryItems[value].Use(this.gameObject);
                    break; // Uscita anticipata: abbiamo trovato il numero
                }
            }
            //if (Input.GetKeyDown(0)) 
            //{
            //    inventoryItems[0].Use(this.gameObject);
            //}
        }
        if (inventoryItems.Count > 0 && inventoryItems != null )
        {
            for (int i = 0; i < inventoryItems.Count; i++)
            {
                Debug.Log(inventoryItems[i]);
            }
        }
    }
}
