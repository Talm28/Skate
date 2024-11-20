using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class StoreItemButton : MonoBehaviour
{
    [SerializeField] private string _itemName;

    private Button _button;
    private Item _item;
    private Image _itemImage;
    private TextMeshProUGUI _itemPrice;

    private void Start() {
        _item = ItemsList.GetItem(_itemName);

        _button = GetComponent<Button>();
        _button.onClick.AddListener(Interact);

        _itemImage = GetComponentsInChildren<Image>().Where(image => image.gameObject != this.gameObject).First(); // Get the image from child and not of the button!
        _itemImage.sprite = _item.Sprite;
        _itemPrice = GetComponentInChildren<TextMeshProUGUI>();
        _itemPrice.text = _item.Cost.ToString();
    }

    private void Interact()
    {
        Debug.Log($"Click on item: {_item.Id}");
    }

    
}
