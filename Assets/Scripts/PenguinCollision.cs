using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        ICollidable coliderObject = other.GetComponent<ICollidable>();
        if(coliderObject == null) return;
        coliderObject.Collide();
    }
}
