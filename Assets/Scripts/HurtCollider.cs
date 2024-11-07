using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class HurtCollider : MonoBehaviour
{
    public UnityEvent onHitReceived;

    Collider hitCollider;
    Collider hurtCollider;

    public void NotifyHit(Collider hitCollider)
    {
        
    }
}
