using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartsUIController : MonoBehaviour
{
    [SerializeField] private GameObject[] _hearts;

    [SerializeField] private PenguinHealth _penguinHealth;

    // Start is called before the first frame update
    void Start()
    {
        EventsController.Instance.playerDamaged.AddListener(UpdateHealthBar);
        UpdateHealthBar();
    }

    public void UpdateHealthBar()
    {
        for(int i = 0; i<_hearts.Length; i++)
        {
            if(i < _penguinHealth.Health)
                _hearts[i].SetActive(true);
            else
                _hearts[i].SetActive(false);
        }
    }
}
