using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseBounce : MonoBehaviour
{
    public float forceMagnitude = 10.0f;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameManager.audioSource.PlayOneShot(gameManager.audioClips[2]);
        // Calculate the impulse force direction as the opposite direction of the collision normal
        Vector3 impulseDirection = -collision.GetContact(0).normal;

        // Apply the impulse force to the collided object
        collision.rigidbody.AddForce(impulseDirection * forceMagnitude, ForceMode.Impulse);
    }

}
