using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBeltScript : MonoBehaviour
{
    [SerializeField] private float forcePower = 1f;
    [SerializeField] private float rotationSpeed = 1f;
    [SerializeField] private Vector2 offset;
    private Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }
    private void OnCollisionStay(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward*forcePower , ForceMode.Force);

    }

    private void Update()
    {
        offset.y = (offset.y + rotationSpeed * Time.deltaTime) % 1;
        renderer.material.mainTextureOffset = offset; 
    }

}
