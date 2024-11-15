using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsController : MonoBehaviour
{
    public static EventsController Instance { get; private set; }

    public UnityEvent scoreCollected;
    public UnityEvent playerDamaged;
    public UnityEvent gameOver;

    private void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
        
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }
}
