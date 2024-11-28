using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class HurtCollider : MonoBehaviour
{
    UnityEvent<HitCollider, HurtCollider> onHitReceived;

    public void NotifyHit(HitCollider hitCollider)
    {
        onHitReceived.Invoke(hitCollider, this);
    }
}
