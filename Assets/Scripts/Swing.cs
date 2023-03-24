using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public float swingSpeed = 1f; // Speed of the swing
    public float swingAngleLimit = 45f; // Maximum angle of the swing
    private Vector3 swingAxis ; // Axis of the swing

    [SerializeField] private float xSwingAxis = 0f;
    [SerializeField] private float ySwingAxis = 0f;
    [SerializeField] private float zSwingAxis = 1f;

    private float currentAngle = 0f; // Current angle of the swing
    private bool isSwingingForward = true; // Flag indicating the swing direction

    void Start()
    {
        // Set the swing axis based on the X, Y, and Z values specified in the Inspector
        swingAxis = new Vector3(xSwingAxis, ySwingAxis, zSwingAxis).normalized;
    }

    void Update()
    {
        // Calculate the new angle based on the current angle and the swing speed
        currentAngle += (isSwingingForward ? swingSpeed : -swingSpeed) * Time.deltaTime;

        // Reverse the swing direction when the angle reaches the swing angle limit
        if (Mathf.Abs(currentAngle) >= swingAngleLimit)
        {
            isSwingingForward = !isSwingingForward;
        }

        // Calculate the rotation based on the swing axis and the new angle
        Quaternion rotation = Quaternion.AngleAxis(currentAngle, swingAxis);

        // Apply the rotation to the object
        transform.rotation = rotation;
    }
}
