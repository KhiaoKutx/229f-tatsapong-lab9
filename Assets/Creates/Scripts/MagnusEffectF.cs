using System;
using UnityEngine;

public class MagnusEffectF : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            kick();
        }
        
        ApplyMagnusEffect();
    }

    void kick()
    {
        rb.linearVelocity = velocity;

        rb.angularVelocity = spin;
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);
        
        rb.AddForce( magnusForce );
    }
}
