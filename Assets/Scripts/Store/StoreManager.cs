using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreManager : MonoBehaviour
{
    [SerializeField] private PenguinSkinController _penguinSkinController;
    [SerializeField] private TextMeshProUGUI _scoreText;
    private int _money;

    // Start is called before the first frame update
    void Start()
    {
        _money = PlayerPrefs.GetInt("Money", 0);
        UpdateScore(0);
    }

    public bool PurchaseItem(Item item)
    {
        if(_money < item.Cost)
            return false;
        UpdateScore(item.Cost);
        return true;
    }

    public void PutItem(Item item)
    {
        _penguinSkinController.PutItem(item);
    }

    public void ClearHat()
    {
        PlayerPrefs.SetInt("Current hat", 0);
        _penguinSkinController.UpdateSkins();
    }
    public void ClearGloves()
    {
        PlayerPrefs.SetInt("Current gloves", 0);
        _penguinSkinController.UpdateSkins();
    }
    public void ClearShoes()
    {
        PlayerPrefs.SetInt("Current shoes", 0);
        _penguinSkinController.UpdateSkins();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    private void UpdateScore(int cost)
    {
        _money -= cost;
        _scoreText.text = _money.ToString();
        PlayerPrefs.SetInt("Money", _money);
    }
}
