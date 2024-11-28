using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ItemsList
{
    public static List<Item> Hats = new List<Item>()
    {
        new Item(0, ItemType.Hat, "Hat_empty", 1, null),
        new Item(1, ItemType.Hat, "baseballCap", 20, Resources.Load<Sprite>("Items/Hats/baseballCap")),
        new Item(2, ItemType.Hat, "beanie", 20, Resources.Load<Sprite>("Items/Hats/beanie")),
        new Item(3, ItemType.Hat, "50sNurse", 30, Resources.Load<Sprite>("Items/Hats/50sNurse")),
        new Item(4, ItemType.Hat, "bowlerHat", 30, Resources.Load<Sprite>("Items/Hats/bowlerHat")),
        new Item(5, ItemType.Hat, "classicFedora", 40, Resources.Load<Sprite>("Items/Hats/classicFedora")),
        new Item(6, ItemType.Hat, "army", 40, Resources.Load<Sprite>("Items/Hats/army")),
        new Item(7, ItemType.Hat, "birthday", 50, Resources.Load<Sprite>("Items/Hats/birthday")),
        new Item(8, ItemType.Hat, "captains", 50, Resources.Load<Sprite>("Items/Hats/captains")),
        new Item(9, ItemType.Hat, "santaHat", 60, Resources.Load<Sprite>("Items/Hats/santaHat")),
        new Item(10, ItemType.Hat, "princess", 60, Resources.Load<Sprite>("Items/Hats/princess")),
        new Item(11, ItemType.Hat, "pinwheel", 70, Resources.Load<Sprite>("Items/Hats/pinwheel")),
        new Item(12, ItemType.Hat, "leprechaun", 70, Resources.Load<Sprite>("Items/Hats/leprechaun")),
        new Item(13, ItemType.Hat, "hardHat", 80, Resources.Load<Sprite>("Items/Hats/hardHat")),
        new Item(14, ItemType.Hat, "crown", 80, Resources.Load<Sprite>("Items/Hats/crown")),
        new Item(15, ItemType.Hat, "viking", 100, Resources.Load<Sprite>("Items/Hats/viking")),
        new Item(16, ItemType.Hat, "tophat", 100, Resources.Load<Sprite>("Items/Hats/tophat"))
    };
    public static List<Item> Gloves = new List<Item>()
    {
        new Item(0, ItemType.Glove, "Gloves_empty", 1, Resources.Load<Sprite>("Items/Gloves/penguin_jump_arm")),
        new Item(1, ItemType.Glove, "Blue_mittens", 30, Resources.Load<Sprite>("Items/Gloves/Blue_mittens")),
        new Item(2, ItemType.Glove, "Pink_mittens", 30, Resources.Load<Sprite>("Items/Gloves/Pink_mittens")),
        new Item(3, ItemType.Glove, "Red_mittens", 30, Resources.Load<Sprite>("Items/Gloves/Red_mittens")),
        new Item(4, ItemType.Glove, "Boxing_gloves", 50, Resources.Load<Sprite>("Items/Gloves/Boxing_gloves")),
        new Item(5, ItemType.Glove, "White_gloves", 50, Resources.Load<Sprite>("Items/Gloves/White_gloves")),
        new Item(6, ItemType.Glove, "Medical_gloves", 70, Resources.Load<Sprite>("Items/Gloves/Medical_gloves"))
    };
    public static List<Item> Shoes = new List<Item>()
    {
        new Item(0, ItemType.Glove, "Shoes_empty", 0, Resources.Load<Sprite>("Items/Shoes/penguin_jump_leg")),
        new Item(1, ItemType.Shoe, "Shoes_blue", 50, Resources.Load<Sprite>("Items/Shoes/Shoes_blue")),
        new Item(2, ItemType.Shoe, "Shoes_red", 50, Resources.Load<Sprite>("Items/Shoes/Shoes_red")),
        new Item(3, ItemType.Shoe, "Shoes_green", 50, Resources.Load<Sprite>("Items/Shoes/Shoes_green")),
    };

    public static Item GetItemByName(string name)
    {
        foreach(Item item in Hats)
            if(item.Name == name)
                return item;
        foreach(Item item in Gloves)
            if(item.Name == name)
                return item;
        foreach(Item item in Shoes)
            if(item.Name == name)
                return item;
        return null;
    }

    public static Item GetItemByIdAndType(ItemType type, int id)
    {
        List<Item> list = null;
        switch(type)
        {
            case ItemType.Hat:
                list = ItemsList.Hats;
                break;
            case ItemType.Glove:
                list = ItemsList.Gloves;
                break;
            case ItemType.Shoe:
                list = ItemsList.Shoes;
                break;
        }
        foreach(Item item in list)
            if(item.Id == id)
                return item;
        return null;
    }


}
