using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ItemsList
{
    public static List<Item> Hats = new List<Item>()
    {
        new Item(1, ItemType.Hat, "Hat_1", Resources.Load<Sprite>("Items/Hats/Hat_1"), 15),
        new Item(2, ItemType.Hat, "Hat_2", Resources.Load<Sprite>("Items/Hats/Hat_2"), 15),
        new Item(3, ItemType.Hat, "Hat_3", Resources.Load<Sprite>("Items/Hats/Hat_3"), 15),
        new Item(4, ItemType.Hat, "Hat_4", Resources.Load<Sprite>("Items/Hats/Hat_4"), 15),
        new Item(5, ItemType.Hat, "Hat_5", Resources.Load<Sprite>("Items/Hats/Hat_5"), 15)
    };

    public static Item GetItem(string name)
    {
        foreach(Item item in Hats)
            if(item.Name == name)
                return item;

        //other item check - TODO

        return null;
    }
}
