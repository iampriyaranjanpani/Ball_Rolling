using UnityEngine;

public class RotateSkyBox : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public Material skyBoxM;

    void Update()
    {
        float rotation = skyBoxM.GetFloat("_Rotation");

        // Update the Y-axis rotation based on the time
        float time = Time.time * rotationSpeed;
        rotation = time;

        // Set the new rotation on the Skybox material
        skyBoxM.SetFloat("_Rotation", rotation);

    }
}

