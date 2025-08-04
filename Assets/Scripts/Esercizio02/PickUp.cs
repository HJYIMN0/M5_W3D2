using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] public SO_Item item;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something has touched me!");
        if (other != null && other.CompareTag("Player"))
        {
            PlayerInventory.Instance.inventoryItems.Add(item);
            Destroy(this.gameObject);
            //Debug.Log("It's the player!");
            //PlayerInventory inventory = other.GetComponentInParent<PlayerInventory>();
            //if (inventory != null)
            //{
            //    Debug.Log("Aggiunto!");
            //    inventory.inventoryItems.Add(item);
            //    Destroy(this.gameObject);
            //}
            //else Debug.Log("Non aggiunto!");
        }
    }
}
