using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Hat,
    Shoe,
    Glove
}

public class Item
{
    public int Id {get; private set;}
    public ItemType Type {get; private set;}
    public string Name {get; private set;}
    public Sprite Sprite {get; private set;}
    public int Cost {get; private set;}

    public Item(int id, ItemType type, string name, int cost, Sprite sprite) 
    {
        Id = id;
        Type = type;
        Name = name;
        Cost = cost;
        Sprite = sprite;
    }

}
