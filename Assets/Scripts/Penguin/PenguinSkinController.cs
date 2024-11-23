using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinSkinController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _hatSprite;
    [SerializeField] private SpriteRenderer _glovesFrontSprite;
    [SerializeField] private SpriteRenderer _glovesBackSprite;
    [SerializeField] private SpriteRenderer _ShoesFrontSprite;
    [SerializeField] private SpriteRenderer _ShoesBackSprite;

    // Start is called before the first frame update
    void Start()
    {
        UpdateSkins();
    }

    public void PutItem(Item item)
    {
        switch(item.Type)
        {
            case ItemType.Hat:
                PlayerPrefs.SetInt("Current hat", item.Id);
                break;
            case ItemType.Glove:
                PlayerPrefs.SetInt("Current gloves", item.Id);
                break;
            case ItemType.Shoe:
                PlayerPrefs.SetInt("Current shoes", item.Id);
                break; 

        }
        UpdateSkins();
    }
    public void UpdateSkins()
    {
        int hatId = PlayerPrefs.GetInt("Current hat", 0);
        int glovesId = PlayerPrefs.GetInt("Current gloves", 0);
        int shoesId = PlayerPrefs.GetInt("Current shoes", 0);

        Item hat = ItemsList.GetItemByIdAndType(ItemType.Hat, hatId);
        Item gloves = ItemsList.GetItemByIdAndType(ItemType.Glove, glovesId);
        Item shoes = ItemsList.GetItemByIdAndType(ItemType.Shoe, shoesId);

        _hatSprite.sprite = hat.Sprite;
        _glovesFrontSprite.sprite = gloves.Sprite;
        _glovesBackSprite.sprite = gloves.Sprite;
        _ShoesFrontSprite.sprite = shoes.Sprite;
        _ShoesBackSprite.sprite = shoes.Sprite;
    }
}
