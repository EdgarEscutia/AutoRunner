using NUnit.Framework;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class HitCollider : MonoBehaviour
{
    UnityEvent<HitCollider, HurtCollider> onHitDelivered;

    List<string> hittableTags;

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < hittableTags.Count; i++)
        {
            if(other.tag == hittableTags[i])
            {

                //NotifyHit();
            }
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        for(int i = 0; i < hittableTags.Count; i++)
        {
            if (hittableTags[i] == col.collider.tag)
            {
                //NotifyHit();            
            }
        }
    }

    public void NotifyHit(HitCollider  HitCollider)
    {
        
    }

}
