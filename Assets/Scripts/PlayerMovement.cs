using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;


    public void MoveLeft(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    public void MoveRight(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    public void MoveForward(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    public void MoveBack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}


