using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class StoreItemButton : MonoBehaviour
{
    [SerializeField] private string _itemName;

    private StoreManager _storeManager;

    private Button _button;
    private Item _item;
    private Image _itemImage;
    private TextMeshProUGUI _itemPrice;
    private bool _isPurchased;

    private void Start() {
        _storeManager = GameObject.FindGameObjectWithTag("Store manager").GetComponent<StoreManager>();
        // Get item by name
        _item = ItemsList.GetItemByName(_itemName);
        // Set onclick function event
        _button = GetComponent<Button>();
        _button.onClick.AddListener(Interact);
        // Get if the player has already purchase the item
        _isPurchased = PlayerPrefs.GetInt(_item.Name, 0) == 1;
        // UI initialization
        _itemImage = GetComponentsInChildren<Image>().Where(image => image.gameObject != this.gameObject).First(); // Get the image from child and not of the button!
        _itemImage.sprite = _item.Sprite;
        _itemPrice = GetComponentInChildren<TextMeshProUGUI>();
        if(_isPurchased)
            _itemPrice.text = "Owned!";
        else
            _itemPrice.text = _item.Cost.ToString();
    }

    private void Interact()
    {
        if(!_isPurchased) // If the item is not purchase yet
        {
            if(!_storeManager.PurchaseItem(_item)) // Not have enough money!
                return; 
            PlayerPrefs.SetInt(_item.Name, 1);
            _isPurchased = true;
            _itemPrice.text = "Owned!";
        }
        _storeManager.PutItem(_item);
        
    }

    
}
