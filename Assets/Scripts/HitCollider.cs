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
        for (int i = 0; i < hittableTags.Count; i++)
        {
            if(other.tag == hittableTags[i])
            {

            }
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        for(int i = 0; i < hittableTags.Count; i++)
        {
            if (hittableTags[i] == col.collider.tag)
            {
                                
            }
        }
    }

    private void NotifyHit(Collider other)
    {
        
    }

}
