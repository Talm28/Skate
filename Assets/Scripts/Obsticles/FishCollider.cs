using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollider : MonoBehaviour, ICollidable
{
    public void Collide()
    {
        EventsController.Instance.scoreCollected.Invoke();
    }
}
