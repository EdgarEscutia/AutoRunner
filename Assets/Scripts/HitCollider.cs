using NUnit.Framework;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class HitCollider : MonoBehaviour
{
    UnityEvent onHitDelivered;
    Collider hitCollider;
    Collider hurtCollider;

    List<string> hittableTags;

    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void NotifyHit(Collider hitCollider)
    {
        
    }

}
