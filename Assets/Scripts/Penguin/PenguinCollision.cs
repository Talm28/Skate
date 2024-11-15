using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        ICollidable coliderObject = other.gameObject.GetComponent<ICollidable>();
        if(coliderObject == null) return;
        coliderObject.Collide();
        Destroy(other.gameObject);
    }
}
