using NUnit.Framework;
using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class HitCollider : MonoBehaviour
{
    public UnityEvent<HitCollider, HurtCollider> onHitDelivered;

    [SerializeField] List<string> hittableTags;

    private void OnTriggerEnter(Collider other)
    {
        CheckCollider(other);
        //for (int i = 0; i < hittableTags.Count; i++)
        //{
        //    if (other.tag == hittableTags[i])
        //    {

        //        //NotifyHit();
        //    }
        //}
    }

    private void CheckCollider(Collider other)
    {
        if (hittableTags.Contains(other.tag))
        {
           HurtCollider hurtCollider = other.GetComponent<HurtCollider>();
            if(hurtCollider)
            {
                hurtCollider.NotifyHit(this);
                onHitDelivered.Invoke(this, hurtCollider);
            }                    
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        CheckCollider(collision.collider);
        //for (int i = 0; i < hittableTags.Count; i++)
        //{
        //    if (hittableTags[i] == col.collider.tag)
        //    {
        //        //NotifyHit();            
        //    }
        //}
    }
}
