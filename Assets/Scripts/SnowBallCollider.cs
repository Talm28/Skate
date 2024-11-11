using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallCollider : MonoBehaviour, ICollidable
{
    public void Collide()
    {
        Debug.Log("Collide a snowball!");
    }
}
