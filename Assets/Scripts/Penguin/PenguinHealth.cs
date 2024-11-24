using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinHealth : MonoBehaviour
{
    public int Health{ get; private set; }

    [SerializeField] private int _startHealth;
    
    private EventsController eventsController;
    private SpriteRenderer[] _penguinSprites;

    // Start is called before the first frame update
    void Start()
    {
        Health = _startHealth;
        
        eventsController = EventsController.Instance;
        eventsController.playerDamaged.AddListener(TakeHealth);

        _penguinSprites = GetComponentsInChildren<SpriteRenderer>();
    }


    public void TakeHealth()
    {
        Health--;
        StartCoroutine(FlashRed());
        if( Health == 0 )
            eventsController.gameOver.Invoke();
    }

    private IEnumerator FlashRed()
    {
        foreach(SpriteRenderer sprite in _penguinSprites)
            sprite.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        foreach(SpriteRenderer sprite in _penguinSprites)
            sprite.color = Color.white;
    }
}
