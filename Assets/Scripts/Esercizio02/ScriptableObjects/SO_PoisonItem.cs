using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "PoisonItem", menuName = "Data/Inventory PoisonItem", order = 2)]
public class SO_PoisonItem : SO_Item
{
    public int dmg = 10;

    public override void Use(GameObject user)
    {
        if (user == null) return;

        LifeController life = user.GetComponent<LifeController>();
        if (life != null)
        { 
            life.TakeDamage(dmg);
            PlayerInventory.Instance.inventoryItems.Remove(this);
            //PlayerInventory inventory = user.GetComponent<PlayerInventory>();
            //inventory.inventoryItems.Remove(this);
        }
    }
}
