using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject target_GameObject;
    private Transform ballTransform;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothSpeed = 0.125f;
    private void Start()
    {
        ballTransform = target_GameObject.GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        Vector3 desiredPosition = ballTransform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
