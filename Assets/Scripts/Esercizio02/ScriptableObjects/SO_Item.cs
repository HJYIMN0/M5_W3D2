using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Item", menuName = "Data/Inventory Object", order = 0)]
public abstract class SO_Item : ScriptableObject
{
    public int itemId;
    public string itemName;
    public string itemDescription;

    public abstract void Use(GameObject user);
}
