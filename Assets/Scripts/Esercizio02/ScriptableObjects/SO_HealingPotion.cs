using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[CreateAssetMenu (fileName = "HealingItem", menuName = "Data/Inventory HealingObject", order = 1)]
public class SO_HealingPotion : SO_Item
{
    public int healingPower = 10;
    public override void Use(GameObject user)
    {
        if (user == null) return;
        LifeController life = user.GetComponent<LifeController>();
        if (life != null) 
        {
            life.Heal(healingPower);
            PlayerInventory.Instance.inventoryItems.Remove(this);
            //PlayerInventory inventory = user.GetComponent<PlayerInventory>();
            //inventory.inventoryItems.Remove(this);
        }
    }
}
