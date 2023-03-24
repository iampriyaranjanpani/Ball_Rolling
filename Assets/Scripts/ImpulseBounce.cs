using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseBounce : MonoBehaviour
{
    public float forceMagnitude = 10.0f;

    private void OnCollisionEnter(Collision collision)
    {
        // Calculate the impulse force direction as the opposite direction of the collision normal
        Vector3 impulseDirection = -collision.GetContact(0).normal;

        // Apply the impulse force to the collided object
        collision.rigidbody.AddForce(impulseDirection * forceMagnitude, ForceMode.Impulse);
    }

}
