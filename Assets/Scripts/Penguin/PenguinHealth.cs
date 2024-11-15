using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinHealth : MonoBehaviour
{
    public int Health{ get; private set; }

    [SerializeField] private int _startHealth;
    
    private EventsController eventsController;

    // Start is called before the first frame update
    void Start()
    {
        Health = _startHealth;
        
        eventsController = EventsController.Instance;
        eventsController.playerDamaged.AddListener(TakeHealth);
    }


    public void TakeHealth()
    {
        Health--;
        if( Health == 0 )
            eventsController.gameOver.Invoke();
    }
}
